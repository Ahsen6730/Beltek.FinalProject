
#region -using
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
# endregion

namespace Beltek.AhsenAslan.FinalProject.UI.Models
{
    [Table("Gallery")]
    public class Gallery
    { 
        [Key]
        public int Id { get; set; }
        public string Url { get; set; }

        [ForeignKey("Product")]
        public int ProductId { get; set; }

        public virtual Product Product { get; set; }

    }
}
