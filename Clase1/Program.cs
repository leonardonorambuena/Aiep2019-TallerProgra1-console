using System;
using System.Collections.Generic;
using System.Linq;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            //FirstExample();
            //SecondExample();

            var califications = new List<int>();

            Console.WriteLine("Cuantas notas va a ingresar:");

            var cant = Convert.ToInt32(Console.ReadLine());

            for(var i = 0; i < cant; i++)
            {
                Console.WriteLine("Ingrese nota "+ (i + 1));
                califications.Add(Convert.ToInt32(Console.ReadLine()));
            }

            var promedio = califications.Average();

            if (promedio >= 40)
            {
                Console.WriteLine("Aprobado con promedio "+promedio);
            }
            else
            {
                Console.WriteLine("Reprobado con promedio "+promedio);
            }

        }

        public static void SecondExample()
        {
            int age = 0;
            int currentYear = DateTime.Now.Year;
            Console.WriteLine("Ingrese año de nacimiento:");
            int birthDay = Convert.ToInt32(Console.ReadLine());

            age = currentYear - birthDay;

            Console.WriteLine($"Su edad es : {age}");
        }

        public static void FirstExample()
        {
            int _area = 0;
            int _altura = 0;
            int _base = 0;

            Console.WriteLine("Ingrese la Base");
            _base = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la Altura");
            _altura = Convert.ToInt32(Console.ReadLine());
            _area = GetArea(_base, _altura);
            Console.WriteLine($"La base es {_base},  El area es {_area}");
            Console.ReadKey();
        }
        public static int GetArea(int _base, int _altura)
        {
            return (_base * _altura) / 2;
        }
    }
}
