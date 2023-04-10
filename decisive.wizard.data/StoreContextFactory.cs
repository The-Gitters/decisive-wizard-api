using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Decisive.Wizard.Data;

namespace Operation.Draconic.Beat.Data;

public class StoreContextFactory : IDesignTimeDbContextFactory<StoreContext>
{
    public StoreContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<StoreContext>();

        optionsBuilder.UseSqlite("Data Source=../store.db");

        return new StoreContext(optionsBuilder.Options);
    }
}