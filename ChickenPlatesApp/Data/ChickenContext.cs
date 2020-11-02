using ChickenPlatesApp.Models;
using Microsoft.EntityFrameworkCore;

namespace ChickenPlatesApp.Data
{
    public class ChickenContext : DbContext
    {
        public ChickenContext(DbContextOptions<ChickenContext> options) : base(options)
        {
        }

        public DbSet<ChickenPlate> ChickenPlates { get; set; }
        public DbSet<ChickenPart> ChickenParts { get; set; }
        public DbSet<Drink> Drinks { get; set; }
        public DbSet<SideDish> SideDishes { get; set; }
    }
}
