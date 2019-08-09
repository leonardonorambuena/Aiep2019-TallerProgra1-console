using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BaseProject.Models
{
    public class Image : BaseModel
    {
        [Key]
        public int ImageId { get; set; }
        [Required]
        public string Path { get; set; }

        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }
    }
}