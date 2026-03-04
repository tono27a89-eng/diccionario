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
                        Console.WriteLine("ingrese nombre");
                        string nombre = Console.ReadLine();
                        Console.WriteLine("ingrese precio");
                        int precio= int.Parse(Console.ReadLine());
                        Console.WriteLine("ingrese peso");
                        int peso= int.Parse(Console.ReadLine());
                        producto.Add(id,(nombre, precio, peso));

                        break;
                        case 2:
                        Console.Write("ID a modificar: ");
                        id = int.Parse(Console.ReadLine());
                        Console.Write("Nuevo nombre: ");
                        nombre = Console.ReadLine();
                        Console.WriteLine("ingrese nuevo precio");
                        precio= int.Parse(Console.ReadLine());
                        Console.WriteLine("ingrese nuevo peso");
                        peso= int.Parse(Console.ReadLine());
                        producto[id] = (nombre, precio, peso);

                        break;
                    case 3:
                        Console.WriteLine("Id a eliminar");
                        id = int.Parse(Console.ReadLine());
                        producto.Remove(id);
                        break;
                        case 4:
                        foreach (var item in producto)
                        {
                            Console.WriteLine("ID: "+item.Key+ "producto: "+item.Value);   
                        }
                        break;
                    default:
                        break;
                }

            } while (opcion != 0);
        }
    }
}
