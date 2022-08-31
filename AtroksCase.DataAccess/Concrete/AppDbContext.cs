using AtroksCase.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace AtroksCase.DataAccess.Concrete
{
    public class AppDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Initial Catalog=dbTelephoneDirectory;Trusted_Connection=True;");
        }

        public DbSet<District> Districts { get; set; }
        public DbSet<Report> Reports { get; set; }
    }
}
