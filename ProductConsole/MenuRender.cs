using System;
using System.Collections.Generic;
using System.Linq;
using ProductConsole.Models;

namespace ProductConsole
{
    public class MenuRender
    {
        public List<Product> Products { get; set; }

        public MenuRender()
        {
            if (Products == null)
               Products = GetProducts(); 
                
        }

        public List<Product> GetProducts()
        {
            using(var db = new ApplicationDbContext())
            {
                return db.Products.ToList();
            }
        }

        public void RenderHeader(string title)
        {
            Console.Clear();
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine(title);
            Console.WriteLine("------------------------------------------------");
        }
        public  void RenderMenu()
        {

            int Option = 0;
            while(Option != 9)
            {
                RenderHeader("Menú Principal");                
                Console.WriteLine("1 - Ingrese un Producto");
                Console.WriteLine("2 - Listar Productos");
                Console.WriteLine("3 - Resumen");
                Console.WriteLine("9 - Salir");
                if(int.TryParse(Console.ReadLine(), out Option))
                {
                    if (Option == 1)
                        RenderCreateProduct();
                    if (Option == 2)
                        RenderListProduct();
                    if (Option == 3)
                        RenderResumeProduct();
                }
            } 
            

        }

        private void RenderResumeProduct()
        {
            RenderHeader("Consolidado");
            Console.WriteLine($"Cantidad de productos registrados : {Products.Count}");
            Console.WriteLine($"Cantidad total de productos: {Products.Sum(x => x.Stock)} ");
            Console.WriteLine($"Valor total en productos: {Products.Sum(x => x.Price)}");
            Console.ReadKey();
        }

        public  void RenderListProduct()
        {
            RenderHeader("Listado de productos");
            foreach(var product in Products)
            {
                Console.WriteLine($"Nombre: {product.Title} | Desscripción: {product.Description} | Precio: {product.Price} | stock: {product.Stock} | total: {product.Total}");
            }

            Console.ReadKey();
        }

        public  void RenderCreateProduct()
        {
            RenderHeader("Ingreso de producto");
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

            // REGISTRO DE PRODUCTO EN MEMORIA
            //Products.Add(product);

            using(var db = new ApplicationDbContext())
            {
                // Registro de base de datos, persistencia de datos
                db.Products.Add(product);
                // se guardan los datos en la base de datos
                db.SaveChanges();
            }

            Console.WriteLine($"El valor total es: {product.Total}");
            Products = GetProducts();
            Console.ReadKey();
        }
        


    }
}