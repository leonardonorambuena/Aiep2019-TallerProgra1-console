using System;

namespace Repaso1
{
    class Program
    {
        static void Main(string[] args)
        {
            string Nombre, Apellido;
            int FechaNacimiento = 0;
            Console.Clear();
            Console.WriteLine("Ingrese su Nombre");
            Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su Apellido");
            Apellido = Console.ReadLine();
            
            int currentYear = DateTime.Now.Year;     
            while(FechaNacimiento == 0)
            {
                Console.WriteLine("Ingrese año de nacimiento");
                int.TryParse(Console.ReadLine(), out FechaNacimiento);

                if (FechaNacimiento > currentYear)
                {
                    Console.WriteLine("El año de nacimiento no puede ser mayor al año actual");
                    FechaNacimiento = 0;
                }
            }

            string NombreCompleto = $"{Nombre} {Apellido}";
            int edad = currentYear - FechaNacimiento;

            Console.WriteLine($"Hola {NombreCompleto}, su edad es {edad}");

        }
    }
}
