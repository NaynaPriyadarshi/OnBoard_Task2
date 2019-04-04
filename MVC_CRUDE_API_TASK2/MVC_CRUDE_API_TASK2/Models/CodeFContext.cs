using System.Data.Entity;

namespace MVC_CRUDE_API_TASK2.Models
{
    public class CodeFContext : DbContext

    {


        public CodeFContext() : base("Name:MyContext") { }

        public DbSet<Customer>Customer { get; set; }

        public DbSet<Product> Product { get; set; }

        public DbSet<Store> Store { get; set; }

        public DbSet<Sales> sales { get; set; }


        

    }
}