using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ClosedXML.Excel;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Barber_Royal
{
    public partial class Reportes : Form
    {
        ConexionDB conexion = new ConexionDB();

        public Reportes()
        {
            InitializeComponent();
            InicializarControles();
        }

        private void InicializarControles()
        {
            // Llenamos el combo de tipos de reporte
            cmbTipoReporte.Items.Clear();
            cmbTipoReporte.Items.AddRange(new string[] { "Clientes", "Barberos", "Citas" });
            cmbTipoReporte.SelectedIndex = 0;

            // Configuraciones iniciales del datepickers
            dtpDesde.Value = DateTime.Today.AddDays(-7);
            dtpHasta.Value = DateTime.Today;

            // Event handlers (si no los tienes ya asignados en el diseñador)
            cmbTipoReporte.SelectedIndexChanged += (s, e) => LoadPreview();
            txtBusqueda.TextChanged += (s, e) => LoadPreview();
            dtpDesde.ValueChanged += (s, e) => LoadPreview();
            dtpHasta.ValueChanged += (s, e) => LoadPreview();
            cmbBarberoFiltro.SelectedIndexChanged += (s, e) => LoadPreview();

            // Cargar lista de barberos al iniciar (para filtro)
            CargarBarberosFiltro();
            LoadPreview();
        }

        private void CargarBarberosFiltro()
        {
            try
            {
                string sql = "SELECT nombre, apellido FROM barberos ORDER BY nombre";
                DataTable dt = EjecutarConsulta(sql, null);
                cmbBarberoFiltro.Items.Clear();
                foreach (DataRow r in dt.Rows)
                {
                    string nombre = (r.Table.Columns.Contains("nombre") ? r["nombre"].ToString() : "");
                    string apellido = (r.Table.Columns.Contains("apellido") ? r["apellido"].ToString() : "");
                    string full = (nombre + " " + apellido).Trim();
                    if (!string.IsNullOrWhiteSpace(full))
                        cmbBarberoFiltro.Items.Add(full);
                }
            }
            catch
            {
                // Si falla, no se blackoutea la app; se silencia, el filtro seguirá vacío
            }
        }

        private DataTable EjecutarConsulta(string sql, Dictionary<string, object> parametros)
        {
            DataTable dt = new DataTable();
            try
            {
                using (MySqlConnection con = conexion.GetConnection())
                {
                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        if (parametros != null)
                        {
                            foreach (var kv in parametros)
                                cmd.Parameters.AddWithValue(kv.Key, kv.Value ?? DBNull.Value);
                        }

                        using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar consulta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }

        private void LoadPreview()
        {
            string tipo = cmbTipoReporte.SelectedItem?.ToString();
            DataTable dt = new DataTable();

            if (tipo == "Clientes")
            {
                string q = string.IsNullOrWhiteSpace(txtBusqueda.Text) ? "%" : "%" + txtBusqueda.Text.Trim() + "%";
                string sql = "SELECT cliente_id, nombre, apellido, nacimiento, telefono, email FROM clientes " +
                             "WHERE nombre LIKE @q OR apellido LIKE @q OR email LIKE @q";

                dt = EjecutarConsulta(sql, new Dictionary<string, object> { { "@q", q } });
                NormalizarColumnasClientes(dt);
            }
            else if (tipo == "Barberos")
            {
                string q = string.IsNullOrWhiteSpace(txtBusqueda.Text) ? "%" : "%" + txtBusqueda.Text.Trim() + "%";

                string sql = @"
        SELECT 
            barbero_id AS ID,
            nombre AS Nombre,
            apellido AS Apellido,
            telefono AS Teléfono,
            email AS Email,
            fecha_registro AS Fecha_Registro
        FROM barberos
        WHERE nombre LIKE @q OR apellido LIKE @q OR email LIKE @q";

                dt = EjecutarConsulta(sql, new Dictionary<string, object> { { "@q", q } });
            }
            else if (tipo == "Citas")
            {
                DateTime desde = dtpDesde.Value.Date;
                DateTime hasta = dtpHasta.Value.Date;
                string sql = @"SELECT cita_id, cliente, barbero, fecha, hora, hora_fin, servicios, observaciones, estado 
                       FROM citas
                       WHERE fecha BETWEEN @desde AND @hasta";

                var parametros = new Dictionary<string, object> { { "@desde", desde }, { "@hasta", hasta } };

                if (!string.IsNullOrWhiteSpace(cmbBarberoFiltro.Text))
                {
                    sql += " AND TRIM(barbero) = TRIM(@barbero)";
                    parametros.Add("@barbero", cmbBarberoFiltro.Text.Trim());
                }
                if (!string.IsNullOrWhiteSpace(txtBusqueda.Text))
                {
                    sql += " AND (cliente LIKE @q OR servicios LIKE @q)";
                    parametros.Add("@q", "%" + txtBusqueda.Text.Trim() + "%");
                }

                dt = EjecutarConsulta(sql, parametros);
            }

            // Asignar a grid
            dgvPreview.DataSource = dt;
            lblRegistro.Text = $"Registros: {dt?.Rows.Count ?? 0}";
            FormatearGridSegunTipo(tipo, dt);
        }

        private void NormalizarColumnasBarberos(DataTable dt)
        {
            if (dt == null) return;
            // Renombrar columnas si es necesario para mostrar encabezados amigables
            RenameColumnIfExists(dt, "barbero_id", "ID");
            RenameColumnIfExists(dt, "nombre", "Nombre");
            RenameColumnIfExists(dt, "apellido", "Apellido");
            RenameColumnIfExists(dt, "telefono", "Teléfono");
            RenameColumnIfExists(dt, "email", "Email");
        }

        private void NormalizarColumnasClientes(DataTable dt)
        {
            if (dt == null) return;
            RenameColumnIfExists(dt, "cliente_id", "ID");
            RenameColumnIfExists(dt, "nombre", "Nombre");
            RenameColumnIfExists(dt, "apellido", "Apellido");
            RenameColumnIfExists(dt, "nacimiento", "Nacimiento");
            RenameColumnIfExists(dt, "telefono", "Teléfono");
            RenameColumnIfExists(dt, "email", "Email");
        }

        private void RenameColumnIfExists(DataTable dt, string oldName, string newName)
        {
            if (dt.Columns.Contains(oldName) && !dt.Columns.Contains(newName))
                dt.Columns[oldName].ColumnName = newName;
        }

        private void FormatearGridSegunTipo(string tipo, DataTable dt)
        {
            // Ejemplo simple: ajustar ancho y formatos de columnas comunes
            if (dgvPreview.Columns.Count == 0) return;

            dgvPreview.AutoResizeColumns();
            dgvPreview.AllowUserToAddRows = false;
            dgvPreview.ReadOnly = true;

            // Si hay columna "Nacimiento" formatear como fecha
            if (dt != null && dt.Columns.Contains("Nacimiento"))
            {
                foreach (DataGridViewColumn c in dgvPreview.Columns)
                {
                    if (c.HeaderText == "Nacimiento")
                    {
                        c.DefaultCellStyle.Format = "yyyy-MM-dd";
                        break;
                    }
                }
            }
        }

        private void ExportToExcel(DataTable dt)
        {
            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar.", "Exportar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx", FileName = "reporte.xlsx" })
            {
                if (sfd.ShowDialog() != DialogResult.OK) return;

                try
                {
                    using (var wb = new XLWorkbook())
                    {
                        wb.Worksheets.Add(dt, "Reporte");
                        wb.SaveAs(sfd.FileName);
                    }
                    MessageBox.Show("Exportado a Excel correctamente.", "Exportar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error exportando a Excel: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ExportToPdf(DataTable dt)
        {
            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar.", "Exportar PDF", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF Files|*.pdf", FileName = "reporte.pdf" })
            {
                if (sfd.ShowDialog() != DialogResult.OK) return;

                try
                {
                    Document pdfDoc = new Document(PageSize.A4.Rotate(), 10f, 10f, 10f, 10f);
                    PdfPTable pdfTable = new PdfPTable(dt.Columns.Count);
                    pdfTable.WidthPercentage = 100;

                    // Cabeceras
                    foreach (DataColumn column in dt.Columns)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(column.ColumnName))
                        {
                            BackgroundColor = BaseColor.LIGHT_GRAY
                        };
                        pdfTable.AddCell(cell);
                    }

                    // Filas
                    foreach (DataRow row in dt.Rows)
                    {
                        foreach (var cell in row.ItemArray)
                        {
                            pdfTable.AddCell(new Phrase(cell?.ToString() ?? ""));
                        }
                    }

                    using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                    {
                        PdfWriter.GetInstance(pdfDoc, stream);
                        pdfDoc.Open();
                        pdfDoc.Add(pdfTable);
                        pdfDoc.Close();
                    }
                    MessageBox.Show("Exportado a PDF correctamente.", "Exportar PDF", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error exportando a PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Convierte el DataGridView a DataTable para exportación
        private DataTable DataGridViewToDataTable(DataGridView dgv)
        {
            var dt = new DataTable();

            // Agregar columnas visibles
            foreach (DataGridViewColumn col in dgv.Columns)
            {
                if (col.Visible)
                    dt.Columns.Add(col.HeaderText);
            }

            // Agregar filas
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.IsNewRow) continue;
                DataRow dr = dt.NewRow();
                int idx = 0;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (dgv.Columns[cell.ColumnIndex].Visible)
                    {
                        dr[idx++] = cell.Value ?? DBNull.Value;
                    }
                }
                dt.Rows.Add(dr);
            }

            return dt;
        }



        // Se obtiene un reporte directamente desde la base de datos sin usar el grid (método alternativo)
        private DataTable ObtenerReporteDirecto(string tipo)
        {
            // Método de ejemplo para extraer directamente desde BD sin usar el grid.
            if (tipo == "Clientes")
                return EjecutarConsulta("SELECT cliente_id AS ID, nombre AS Nombre, apellido AS Apellido, nacimiento AS Nacimiento, telefono AS Teléfono, email AS Email FROM clientes", null);

            if (tipo == "Barberos")
                return EjecutarConsulta("SELECT COALESCE(barbero_id,id) AS ID, COALESCE(nombre,nombre_barbero) AS Nombre, COALESCE(apellido,'') AS Apellido, COALESCE(telefono,'') AS Teléfono, COALESCE(email,'') AS Email FROM barberos", null);

            if (tipo == "Citas")
                return EjecutarConsulta("SELECT cita_id AS ID, cliente AS Cliente, barbero AS Barbero, fecha AS Fecha, hora AS Hora, hora_fin AS HoraFin, servicios AS Servicios, observaciones AS Observaciones, estado AS Estado FROM citas", null);

            return new DataTable();
        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            DataTable dt = DataGridViewToDataTable(dgvPreview);
            ExportToExcel(dt);
        }

        private void btnExportarPDF_Click(object sender, EventArgs e)
        {
            DataTable dt = DataGridViewToDataTable(dgvPreview);
            ExportToPdf(dt);
        }

        private void Reportes_Load(object sender, EventArgs e)
        {

        }
    }
}
