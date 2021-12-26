
#region -using
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
# endregion

namespace Beltek.AhsenAslan.FinalProject.UI.Models
{
    [Table("Category")]
    public class Category
    { 
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Product> Product { get; set; }

    }
}
