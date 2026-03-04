using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace diccionario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, (string nombre, int precio, int peso)> producto = new Dictionary<int, (string, int, int)>();
            int opcion;
            do
            {
                Console.WriteLine("1. agregar producto");
                Console.WriteLine("2. modificar ");
                Console.WriteLine("3. eliminar");
                Console.WriteLine("4. ver");
                int.TryParse(Console.ReadLine(), out opcion);
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("ingrese id de producto");
                        int.TryParse(Console.ReadLine(), out int id);
                        if (producto.ContainsKey(id))
                        {
                         
                        }
                        Console.WriteLine("ingrese nombre");
                        nombre
                        break;
                    default:
                        break;
                }

            } while (opcion != 0);
        }
    }
}
