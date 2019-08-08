using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BaseProject.Models
{
  public class ApplicationDbContext : IdentityDbContext<User, Role, string>
  {

    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
        
    }

  }
}