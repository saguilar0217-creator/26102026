using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // File.WriteAllText("archivo1.txt", "me gusta estar con ustedes\nmegusta programar");
            string[] lineas = File.ReadAllLines("archivo1.txt");

            foreach (string line in lineas)
            {
                Console.WriteLine(line);
            }

            Dictionary<long,Producto> listaProducto= new Dictionary<long,Producto>();


            Console.ReadKey();

        }
    }
}
