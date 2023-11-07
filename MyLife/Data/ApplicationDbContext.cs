using Microsoft.EntityFrameworkCore;
using MyLife.Models;

namespace MyLife.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){
        }
        public DbSet<Club> Clubs { get; set; }
        public DbSet<Race> Races { get; set; }
        public DbSet<Address> Addresses { get; set; }
    }
}
