using System.ComponentModel.DataAnnotations;

namespace EarthlyRemedies.Models
{
  public class Remedy
  {

    public int RemedyId { get; set; }
    [Required]
    [StringLength(50)]
    public string Name { get; set; }
    [Required]
    public string Details { get; set; }

    [StringLength(30)]
    public string Ailment { get; set; }
    [Required]
    public string Category { get; set; }
    public string Ingredients { get; set; }

    public int UserId { get; set; }

    // public decimal Rating { get; set; }
    // public int UserId {get; set;}
  }
}