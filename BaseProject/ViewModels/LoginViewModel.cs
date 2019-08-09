using System.ComponentModel.DataAnnotations;

namespace BaseProject.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [EmailAddress(ErrorMessage = "El campo {0}, debe ser un correo válido")]
        [Display(Name = "Correo")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Display(Name = "Contraseña")]
        public string Password { get; set; }
    }
}