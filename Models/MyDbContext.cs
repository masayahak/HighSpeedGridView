﻿using System.Data.Entity;

namespace GridPager.Models
{
    public partial class MyDbContext : DbContext
    {
        public MyDbContext()
            : base("name=MyDbConnection")
        {
        }

        public virtual DbSet<T売上> T売上s { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
