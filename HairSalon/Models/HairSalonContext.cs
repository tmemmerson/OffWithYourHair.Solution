using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HairSalon.Models
{
  public class HairSalonContext : IdentityDbContext<ApplicationUser>
  {
    public virtual DbSet<Stylist> Stylists { get; set; }
    public DbSet<Client> Clients { get; set; }
    public HairSalonContext(DbContextOptions options) : base(options) { }
  }
}
