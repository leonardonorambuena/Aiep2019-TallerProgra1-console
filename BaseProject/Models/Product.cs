using System.ComponentModel.DataAnnotations;

namespace BaseProject.Models
{
    public class Product : BaseModel
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        public string ProductTitle { get; set; }

        public string Description { get; set; }

        public int ProductPrice { get; set; }

    }
}