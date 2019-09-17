using SimpleCRUD.Models;
using System.Data.Entity;

namespace SimpleCRUD.DataBase
{

    public class SimpleCRUDContext : DbContext
    {

        public SimpleCRUDContext() : base("name=SimpleCRUDContext")
        {

        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Address> Addresses { get; set; }
    }
}