using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace EarthlyRemedies.Models
{
  public class Category
  {
    public Category()
    {
      this.Remedies = new HashSet<CategoryRemedy>();
    }

    public int CategoryId { get; set; }
    public string Name { get; set; }
    public virtual ICollection<CategoryRemedy> Remedies { get; set; }

  }
}
