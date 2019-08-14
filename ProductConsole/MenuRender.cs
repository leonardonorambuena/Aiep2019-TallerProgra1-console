using System;
using ProductConsole.Models;

namespace ProductConsole
{
    public class MenuRender
    {
        public static void RenderMenu()
        {
            int Option = 0;
            Console.WriteLine("1 - Ingrese un Producto");
            Console.WriteLine("2 - Listar Productos");
            
            if(int.TryParse(Console.ReadLine(), out Option))
            {
                if (Option == 1)
                    RenderCreateProduct();
            }

        }

        public static void RenderCreateProduct()
        {
            var product = new Product();
            Console.WriteLine("Ingrese Nombre del Productos");
            product.Title = Console.ReadLine();
            Console.WriteLine("Ingrese descripción");
            product.Description = Console.ReadLine();

            int Price = 0, Stock = 0;

            while(Price <= 0) 
            {
                Console.WriteLine("Ingrese Precio");
                if(!int.TryParse(Console.ReadLine(),out Price))
                    Console.WriteLine("Por favor ingrese solo numeros, deben ser mayores a 0");
            }

            
            while(Stock <= 0) 
            {
                Console.WriteLine("Ingrese Cantidad");
                if(!int.TryParse(Console.ReadLine(),out Stock))
                    Console.WriteLine("Por favor ingrese solo numeros, deben ser mayores a 0");
            }

            product.Price = Price;
            product.Stock = Stock;

            Console.WriteLine($"El valor total es: {product.Total}");
        }
        


    }
}