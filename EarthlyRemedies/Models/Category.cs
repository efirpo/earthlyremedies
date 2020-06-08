using System.ComponentModel.DataAnnotations;

namespace EarthlyRemedies.Models
{
  public class Category
  {
    [Required]
    public int CategoryId { get; set; }
    [Required]
    [StringLength(20)]
    public int Name { get; set; }

  }
}
