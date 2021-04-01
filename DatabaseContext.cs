using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SQLite
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Testi> Testi { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite(@"Data Source=/tmp/testi.db");
    }
}
