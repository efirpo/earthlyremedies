using System.Collections.Generic;

namespace EarthlyRemedies.Models
{
  public class CategoryRemedy
  {
    public int CategoryRemedyId { get; set; }
    public int CategoryId { get; set; }
    public int RemedyId { get; set; }
    public virtual Category Category { get; set; }
    public virtual Remedy Remedy { get; set; }
  }
}