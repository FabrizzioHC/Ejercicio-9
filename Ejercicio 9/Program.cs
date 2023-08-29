using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero_1, numero_2, numero_3;

            Console.WriteLine("ingrese el primer numero:");
            numero_1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el segundo numero:");
            numero_2 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el tercer numero:");
            numero_3 = int.Parse(Console.ReadLine());
            // (&&) se utiliza para combinar dos expresiones
            if (numero_1 != numero_2 && numero_1 != numero_3 && numero_2 != numero_3)
            {
                int mayor = Math.Max(numero_1, Math.Max(numero_2, numero_3));
                Console.WriteLine($"el numero mayor de los tres numeros q puso es: {mayor}");
            }
            else
            {
                Console.WriteLine("los numeros deben ser diferentes entre sí.");
            }
            Console.WriteLine("presione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
    }
