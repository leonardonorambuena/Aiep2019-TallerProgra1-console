using System.ComponentModel.DataAnnotations;

namespace ProductProject.ViewModels
{
  public class PruebaViewModel
  {
    [Required(ErrorMessage = "El {0} es requerido")]
    [Display(Name = "Nombre")]
    public string Name { get; set; }

    [Required]
    public string Comment { get; set; }
  }
}