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

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Remedy>()
      .HasData(
      new Remedy { RemedyId = 10, Name = "Mucus Melter", Details = "L-Acetyl Cysteine, taken daily, will shorten duration of respiratory ailments.", Ailment = "chest congestion", Category = "respiratory" },
      new Remedy { RemedyId = 11, Name = "Dandruff Buster", Details = "Castor oil rubbed into the scalp, every night before bed, for one week.", Ailment = "dandruff", Category = "skin" },
      new Remedy { RemedyId = 3, Name = "Dry Eye Relief", Details = "Mega doses of Omega 3s for LIFE!!!!", Ailment = "dry eyes", Category = "eyes" },
      new Remedy { RemedyId = 4, Name = "Fungus Foiler", Details = "Soak the affected area in apple cider vinegar twice a day until cured", Ailment = "foot fungus", Category = "skin" },
      new Remedy { RemedyId = 5, Name = "Polish Tummy Cure", Details = "One shot of vodka, followed by one shot of fresh ginger juice, daily until symptoms resolve.", Ailment = "digestive illness", Category = "GI" },
      new Remedy { RemedyId = 6, Name = "Sunburn salve", Details = "apply earl grey tea to the affected area 5 times a day until burn goes away", Ailment = "sunburn", Category = "skin" },
      new Remedy { RemedyId = 7, Name = "Heartburn Helper", Details = "Heat 4 oz water to body temperature.  Add 1 oz fresh lemon juice. Drink slowly.", Ailment = "heartburn", Category = "GI" },
      new Remedy { RemedyId = 8, Name = "Nighttime Salve", Details = "Mix 2 drops eucalyptus oil, 1 drop peppermint oil, and 1 drop tea tree oil into 1 oz neutral oil or balm.  Rub on throat, chest and upper back before sleep.", Ailment = "cough", Category = "respiratory" },
      new Remedy { RemedyId = 9, Name = "Eye obsruction removal", Details = "If something is in your eye, pull your upper eyelid over your lower one, in an attempt to scrape out the obstruction", Ailment = "eye obstruction", Category = "eyes" }
      );
    }


  }
}