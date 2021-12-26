#region -using
using Microsoft.EntityFrameworkCore;
# endregion

namespace Beltek.AhsenAslan.FinalProject.UI.Models
{
    public class DataBaseContext :DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categorys { get; set; }
        public DbSet<Price> Prices { get; set; }
        public DbSet<Gallery> Gallerys { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {


            optionsBuilder.UseSqlServer(@"data source=.;initial catalog=BeltekDB;integrated security=True;");
        }
    }
}
