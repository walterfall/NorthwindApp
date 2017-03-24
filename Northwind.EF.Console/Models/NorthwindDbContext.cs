
using Microsoft.EntityFrameworkCore;

namespace Northwind.EF.Console.Models
{
    public partial class NorthwindDbContext : DbContext
    {
        public virtual DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // 實際上會放在 config, 這裡用於範例做測試
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Northwind.Console;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
