using decisive-wizard.Domain.Catalog;
using Microsoft.EntityFrameworkCore;

namespace decisive-wizard.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {
        }

        public DbSet<Item> Items { get; set; }
    }
}
