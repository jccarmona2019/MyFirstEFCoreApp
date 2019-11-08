using Microsoft.EntityFrameworkCore;

namespace MyFirstEFCoreApp
{
    public class AppDbContext : DbContext
    {
        private const string ConnectionString =            //#A
            @"Data Source=localhost\\af6b76fe0213,1433;Initial Catalog=MyFirstEfCoreDb;
             Persist Security Info=True;User ID=sa;Password=Test@12345";

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString); //#B
        }

        public DbSet<Book> Books { get; set; }
    }
}