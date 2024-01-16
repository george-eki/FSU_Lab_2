using Microsoft.EntityFrameworkCore;

namespace Lab_2.Models
{
    public class ItemContext : DbContext
    {
        public virtual DbSet<Item> Items { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite(@"DataSource = ItemDB.db");
        }
        public ItemContext(DbContextOptions options) : base(options)
        {
        }
        public ItemContext()
        {
            
        }
    }
}
