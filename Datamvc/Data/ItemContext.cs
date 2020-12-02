using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Datamvc.Data
{
    public class ItemContext : DbContext
    {
        public ItemContext(DbContextOptions<ItemContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Item> Items { get; set; }
        public DbSet<LogData> LogData { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
