using System;
using Guia1.Helpers;
namespace Guia1
{
    class Program
    {
        static void Main(string[] args)
        {
            if (NumberHelper.IsPanDigital(01234556789))
            Console.WriteLine("Es pandigital");
            else 
            {
                Console.WriteLine("No es pandigital");
            }
            


        }

        public static void Exercise1()
        {
            Console.WriteLine("Ingrese su Nombre: ");

            string firstName = Console.ReadLine();

            Console.WriteLine("Ingrese su Apellido: ");

            string lastName = Console.ReadLine();

            Console.WriteLine($"Su nomber completo es {firstName} {lastName}");
            
        }

        public static void Exercise2()
        {
            int vNeto = 0, price = 0, count = 0, total = 0;

            Console.WriteLine("Ingrese precio: ");
            price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese cantidad: ");
            count = Convert.ToInt32(Console.ReadLine());
            vNeto = count * price;
            int iva = Convert.ToInt32(vNeto * 0.19);
            total = iva + vNeto;

            Console.WriteLine($"Valor neto {vNeto}");

            Console.WriteLine($"Iva {iva}");

            Console.WriteLine($"Total {total}");
        }
    }
}
