using Microsoft.EntityFrameworkCore;

namespace EarthlyRemedies.Models
{
  public class EarthlyRemediesContext : DbContext
  {
    public EarthlyRemediesContext(DbContextOptions<EarthlyRemediesContext> options)
        : base(options)
    {
    }

    public DbSet<Remedy> Remedies { get; set; }
    // public DbSet<Ailment> Ailments { get; set; }
    // public DbSet<AilmentRemedy> AilmentRemedy { get; set; }
  }
}