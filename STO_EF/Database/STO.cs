using STO_EF.Databse.Tables;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
namespace STO_EF
{
    public class STO : DbContext
    {
        
        public DbSet<BillTable> billTable { get; set; }
        public DbSet<CarsTable> carsTable { get; set; }
        public DbSet<OrdersTable> ordersTable { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var connectionStringBuilder = new SqliteConnectionStringBuilder()
                {
                    DataSource = "STO.sqlite"
                };
                var connectionString = connectionStringBuilder.ToString();
                var connection = new SqliteConnection(connectionString);
                optionsBuilder.UseSqlite(connection);
            }
        }
    }
}