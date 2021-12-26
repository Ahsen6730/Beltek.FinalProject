
#region -using
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
# endregion

namespace Beltek.AhsenAslan.FinalProject.UI.Models
{
   
    [Table("Price")]
    public class Price
    {
        [Key]
        public int Id { get; set; }
        public double Quantity { get; set; }
        [ForeignKey("Product")]
        public int ProductId  { get; set; }
        public DateTime UpdateDate { get; set; }
        public virtual Product Product { get; set; }


    }
}
