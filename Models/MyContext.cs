using Microsoft.EntityFrameworkCore;

namespace RecordStore.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Record> Records { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}