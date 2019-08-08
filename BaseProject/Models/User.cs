using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace BaseProject.Models
{
  public class User : IdentityUser
  {
    [Required]
    [MaxLength(250)]
    public string FirstName { get; set; }
    [Required]
    [MaxLength(250)]
    public string LastName { get; set; }

    public string FullName => $"{FirstName} {LastName}";

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }
  }
}