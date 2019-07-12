using System;
using System.Collections.Generic;
using System.Linq;

namespace Dfd
{
    class Program
    {
        static void Main(string[] args)
        {
            //sueldo();
            //WhileExample();
            //Acumulador();
            //ForExample();
            /* for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(i);
            }
            string opcion = "";
            do
            {
                Console.WriteLine("¿Desea continuar S/N? ");
                opcion = Console.ReadLine().ToUpper();
            }while(opcion != "N");*/

            int number = 0;
            do 
            {
                Console.WriteLine("Ingrese Numero mayor a 100");
                number = Convert.ToInt32(Console.ReadLine());
            }
            while(number <= 100);

        }

        static void ForExample()
        {
            int contador = 0;
            int acumulador = 0;    
            //List<int> notas = new List<int>();
            for(int x = 0; x < 5; x++)
            {
                Console.WriteLine($"Ingrese Nota: {x + 1}");
                var nota = Convert.ToInt32(Console.ReadLine());

                //notas.Add(nota);

                //notas.Where(i => i < 40).Average();

                if (nota < 40)
                {
                    contador++;
                    acumulador = acumulador + nota;
                }
            }

            if (contador <= 0)
                Console.WriteLine("Son todos mateos, estudian redes");
            else 
                Console.WriteLine("El promedio de notas rojas es: "+ (acumulador / contador));
            
            //foreach(var item in notas)
                //Console.WriteLine(item);
    


             /*
              int[] numbers = new int[]{0,5,4};
            Console.WriteLine("Con Foreach");
            foreach(var number in numbers)
                Console.WriteLine(number);
            Console.WriteLine("Con For");
            for(int i = 0; i < numbers.Length; i++)
                Console.WriteLine(numbers[i]);
              */
            

        }

        static void WhileExample()
        {
            int number = 0;

            while(number < 5)
            {
                Console.WriteLine("Ingrese un numero");
                var num = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("El numero es" + num);

                number++;
            }
        }

        static void Acumulador()
        {
            int acmulador = 0;

            for(int i = 1; i <= 5; i = i +2)
            {
                Console.WriteLine("Ingrese numero");
                acmulador = acmulador + Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine($"El resultado es {acmulador}");
        }

        static void vuelto()
        {
            int ammount = 0;
            int due = 1500;
            int result = 0;
            Console.WriteLine("Ingrese monto a pagar");
            ammount = Convert.ToInt32(Console.ReadLine());
            if(ammount >= due)
            {
                result = ammount - due;
                Console.WriteLine($"Vuelto: {result}");
            }
            else 
                Console.WriteLine("Monto insuficiente");
        }
        static void IsPositiveNumber()
        {
            try
            {
                var number = 0;
                Console.WriteLine("Ingrese un numero: ");
                number = Convert.ToInt32(Console.ReadLine());
                if (number >= 0)
                    Console.WriteLine("Numero ingresado es mayor que 0");
                else 
                    Console.WriteLine("Numero ingresado menor a 0");
                Console.ReadKey();
            }
            catch(Exception e)
            {
                Console.WriteLine("No se ingresaron numeros");
            }
            
        }
        static void sueldo()
        {
            int bruto = 0;
            int liquido = 0;
            int afp = 0;
            int salud = 0;
            Console.WriteLine("Ingrese sueldo bruto:");
            try 
            {
                do{
                    var bruto_text = Console.ReadLine();
                    int.TryParse(bruto_text, out bruto);

                    if (bruto == 0)
                        Console.WriteLine("Por favor ingrese un numero");
                }
                while(bruto == 0);
                

                Console.WriteLine(bruto);

            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            afp = (bruto * 12)/100;
            salud = (bruto * 7)/100;
            liquido = bruto - (afp + salud);

            Console.WriteLine($"El sueldo liquido :{liquido}");
            Console.WriteLine($"El descuento de AFP es:{afp}");
            Console.WriteLine($"El descuento de salud es: {salud}");
            Console.ReadLine();
            
        }
    }
}
