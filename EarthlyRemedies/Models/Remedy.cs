namespace EarthlyRemedies.Models
{
  public class Remedy
  {
    public int RemedyId { get; set; }
    public string Name { get; set; }
    public string Details { get; set; }
    public string Ailment { get; set; }
    public string Category { get; set; }

    // public decimal Rating { get; set; }
    // public int UserId {get; set;}
  }
}