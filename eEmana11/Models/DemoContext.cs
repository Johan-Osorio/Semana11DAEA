using Microsoft.EntityFrameworkCore;

namespace eEmana11.Models
{
    public class DemoContext:DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Detail> Details { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Product> Products { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=LAB1504-29\\SQLEXPRESS; " + "Initial Catalog=DemoDB; Integrated Security=True; trustservercertificate=True");
        }
    }
}
