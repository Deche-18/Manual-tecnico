using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barber_Royal
{
    internal class ComboboxItem
    {
        public string Text { get; set; }    // Lo que se mostrará en el ComboBox
        public object Value { get; set; }   // El valor real asociado (por ejemplo, el ID)

        public override string ToString()
        {
            return Text; // Esto permite que el ComboBox muestre el texto
        }
    }
}
