using Microsoft.EntityFrameworkCore;
using ecommerce.Models;

namespace ecommerce.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
    }
}
