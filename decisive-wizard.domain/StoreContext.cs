﻿using Decisive.Wizard.Domain.Catalog;
using Microsoft.EntityFrameworkCore;

namespace Decisive.Wizard.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        { }

        public DbSet<Item> Items { get; set; }
    }
}
