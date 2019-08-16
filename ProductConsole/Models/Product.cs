using System.ComponentModel.DataAnnotations;

namespace ProductConsole.Models
{
    public class Product
    {
        [Key]
        public int PorductId { get; set; }
        public string Title { get; set; }

        public string Description { get; set; }

        public int Price { get; set; } = 0;

        public int Stock { get; set; } = 0;

        public int Total => Price * Stock;
    }
}