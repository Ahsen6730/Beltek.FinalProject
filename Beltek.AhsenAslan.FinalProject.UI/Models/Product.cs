
#region -using
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
# endregion

namespace Beltek.AhsenAslan.FinalProject.UI.Models
{
    [Table("Product")]
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Detail{ get; set; }
        [ForeignKey("Category")]
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<Price> Price { get; set; }
        public virtual ICollection<Gallery> Gallery { get; set; }


    }
}
