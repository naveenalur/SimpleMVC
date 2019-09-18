using SimpleCRUD.Models;
using System.Data.Entity;
using SimpleCRUD.Dto;

namespace SimpleCRUD.DataBase
{

    public class SimpleCRUDContext : DbContext
    {

        public SimpleCRUDContext() : base("name=SimpleCRUDContext")
        {

        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<AddedCustomerGraph> AddedCustomerGraphs { get; set; }
    }
}