using System.ComponentModel.DataAnnotations;

namespace BaseProject.ViewModels
{
  public class RegisterViewModel
  {
    [EmailAddress(ErrorMessage = "El {0} no es un correo válido")]
    [Required(ErrorMessage = "El {0} es requerido")]
    [Display(Name = "Correo")]
    public string Email { get; set; }
    [MaxLength(250)]
    [Required(ErrorMessage = "El {0} es requerido")]
    [Display(Name = "Nombre")]
    public string FirstName { get; set; }

    [Required(ErrorMessage = "El {0} es requerido")]
    [Display(Name = "Appellido")]
    [MaxLength(250)]
    public string LastName { get; set; }
    [Required(ErrorMessage = "El {0} es requerido")]
    [Display(Name = "Contraseña")]
    public string Password { get; set; }

    [Required(ErrorMessage = "El {0} es requerido")]
    [Display(Name = "Confirme Contraseña")]
    [Compare("Password")]
    public string ConfirmPassword { get; set; }

  }
}