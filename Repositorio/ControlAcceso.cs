using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Barber_Royal
{
    public static class ControlAcceso
    {
        public static bool PermitirAcceso(string tipoUsuario, string nombreFormulario)
        {
            tipoUsuario = tipoUsuario.Trim().ToLower();

            if (tipoUsuario == "administrador")
            {
                return true;
            }

            if (tipoUsuario == "usuario") 
            {
                string[] formulariosPermitidos = { "Citas", "RegistroDeClientescs" };

                foreach (string form in formulariosPermitidos)
                {
                    if (form.ToLower() == nombreFormulario.ToLower()) 
                        return true;
                }

                return false;
            }

            return false;
        }


        public static void MostrarDenegado()
        {
            MessageBox.Show("No tienes permiso para acceder a este formulario.",
                            "Acceso denegado",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
        }
    }
}