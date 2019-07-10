using System;

namespace Dfd
{
    class Program
    {
        static void Main(string[] args)
        {
            //sueldo();
            //WhileExample();
            Acumulador();
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
