using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    public class Producto
    {
        private long codigo;
        private string nombre;
        private decimal precio;

        public Producto()
        {
        }

        public Producto(long codigo, string nombre, decimal precio)
        {
            this.Codigo = codigo;
            this.Nombre = nombre;
            this.Precio = precio;

        }

        public long Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public decimal Precio { get => precio; set => precio = value; }

        public override string ToString()
        {
            return $"Código:{codigo} Nombre:{nombre}";|
        }
        
    }

}
