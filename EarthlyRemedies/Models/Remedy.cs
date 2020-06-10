using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;

namespace EarthlyRemedies.Models
{
  public class Remedy
  {
    public Remedy()
    {
      this.Categories = new HashSet<CategoryRemedy>();
    }
    public int RemedyId { get; set; }
    [Required]
    [StringLength(50)]
    public string Name { get; set; }
    [Required]
    public string Details { get; set; }

    [StringLength(30)]
    public string Ailment { get; set; }
    public string Ingredients { get; set; }
    public virtual ICollection<CategoryRemedy> Categories { get; set; }
    public int UserId { get; set; }

  }
}