﻿using System;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext: DbContext
    {
        public DbSet<Value> Values { get; set; }

        public DataContext(DbContextOptions options): base(options)
        {            
        }


        protected override void OnModelCreating(ModelBuilder builder) {
            builder.Entity<Value>()
                .HasData(
                    new Value(1, "Value 101"),
                    new Value(2, "Value 102"),
                    new Value(3, "Value 103")
                );
        }

    }
}
