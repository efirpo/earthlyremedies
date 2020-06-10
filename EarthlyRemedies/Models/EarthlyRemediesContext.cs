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
    public DbSet<Rating> Ratings { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Category> Categories { get; set; }
    public virtual DbSet<CategoryRemedy> CategoryRemedy { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Remedy>()
      .HasData(
      new Remedy { RemedyId = 1, Name = "Mucus Melter", Details = "L-Acetyl Cysteine, taken daily, will shorten duration of respiratory ailments.", Ailment = "chest congestion", Ingredients = "L-Acetyl Cysteine", UserId = 1 },
      new Remedy { RemedyId = 2, Name = "Dandruff Buster", Details = "Castor oil rubbed into the scalp, every night before bed, for one week.", Ailment = "dandruff", Ingredients = "castor oil", UserId = 2 },
      new Remedy { RemedyId = 3, Name = "Sore Muscle Balm", Details = "Mix 2 drops eucalyptus oil, 1 drop peppermint oil, and 1 drop tea tree oil into 1 oz neutral oil or balm.  Rub on sore muscles before sleep.", Ailment = "muscle soreness", Ingredients = "tea tree oil, peppermint, eucalyptus", UserId = 2 },
      new Remedy { RemedyId = 4, Name = "Dry Eye Relief", Details = "Mega doses of Omega 3s for LIFE!!!!", Ailment = "dry eyes", Ingredients = "Omega 3", UserId = 1 },
      new Remedy { RemedyId = 5, Name = "Fungus Foiler", Details = "Soak the affected area in apple cider vinegar twice a day until cured", Ailment = "foot fungus", Ingredients = "apple cider vinegar", UserId = 2 },
      new Remedy { RemedyId = 6, Name = "Polish Tummy Cure", Details = "One shot of vodka, followed by one shot of fresh ginger juice, daily until symptoms resolve.", Ailment = "digestive illness", Ingredients = "ginger, vodka", UserId = 1 },
      new Remedy { RemedyId = 7, Name = "Sunburn salve", Details = "apply earl grey tea to the affected area 5 times a day until burn goes away", Ailment = "sunburn", Ingredients = "tea", UserId = 2 },
      new Remedy { RemedyId = 8, Name = "Heartburn Helper", Details = "Heat 4 oz water to body temperature.  Add 1 oz fresh lemon juice. Drink slowly.", Ailment = "heartburn", Ingredients = "lemon", UserId = 1 },
      new Remedy { RemedyId = 9, Name = "Nighttime Salve", Details = "Mix 2 drops eucalyptus oil, 1 drop peppermint oil, and 1 drop tea tree oil into 1 oz neutral oil or balm.  Rub on throat, chest and upper back before sleep.", Ailment = "cough", Ingredients = "tea tree oil, peppermint, eucalyptus", UserId = 2 },
      new Remedy { RemedyId = 10, Name = "Eye obsruction removal", Details = "If something is in your eye, pull your upper eyelid over your lower one, in an attempt to scrape out the obstruction", Ailment = "eye obstruction", Ingredients = "", UserId = 1 }
      );

      builder.Entity<Rating>()
      .HasData(
        new Rating { RatingId = 1, Stars = 1, RemedyId = 2, UserId = 2, Comments = "Almost killed me!" },
        new Rating { RatingId = 2, Stars = 3, RemedyId = 2, UserId = 1, Comments = "Not sure it did anything." },
        new Rating { RatingId = 3, Stars = 5, RemedyId = 2, UserId = 3, Comments = "Best ever!!!" }
      );

      builder.Entity<User>()
      .HasData(
        new User { Id = 1, FirstName = "Ethan", LastName = "Firpo", Username = "efirpo", Password = "epicodusRocks" },
        new User { Id = 2, FirstName = "Tyler", LastName = "Bates", Username = "tyty", Password = "x" }


      );

      builder.Entity<Category>()
      .HasData(
        new Category { CategoryId = 1, Name = "GI" },
        new Category { CategoryId = 2, Name = "Respiratory" },
        new Category { CategoryId = 3, Name = "Skin" },
        new Category { CategoryId = 4, Name = "Eyes" },
        new Category { CategoryId = 5, Name = "Hair" },
        new Category { CategoryId = 6, Name = "Musculoskeletal" },
        new Category { CategoryId = 7, Name = "Endocrine" },
        new Category { CategoryId = 8, Name = "Chakra" },
        new Category { CategoryId = 9, Name = "Pineal" },
        new Category { CategoryId = 10, Name = "Lymphatic" },
        new Category { CategoryId = 11, Name = "Cardiovascular" },
        new Category { CategoryId = 12, Name = "Digestive" },
        new Category { CategoryId = 13, Name = "Nerve" },
        new Category { CategoryId = 14, Name = "Reproductive" }

      );

      builder.Entity<CategoryRemedy>()
      .HasData(

        new CategoryRemedy { CategoryRemedyId = 1, CategoryId = 2, RemedyId = 1 },
        new CategoryRemedy { CategoryRemedyId = 2, CategoryId = 5, RemedyId = 2 },
        new CategoryRemedy { CategoryRemedyId = 3, CategoryId = 6, RemedyId = 3 },
        new CategoryRemedy { CategoryRemedyId = 4, CategoryId = 4, RemedyId = 4 },
        new CategoryRemedy { CategoryRemedyId = 5, CategoryId = 3, RemedyId = 5 },
        new CategoryRemedy { CategoryRemedyId = 6, CategoryId = 12, RemedyId = 6 },
        new CategoryRemedy { CategoryRemedyId = 7, CategoryId = 3, RemedyId = 7 },
        new CategoryRemedy { CategoryRemedyId = 8, CategoryId = 12, RemedyId = 8 },
        new CategoryRemedy { CategoryRemedyId = 9, CategoryId = 2, RemedyId = 9 },
        new CategoryRemedy { CategoryRemedyId = 10, CategoryId = 4, RemedyId = 10 }

      );

    }


  }
}