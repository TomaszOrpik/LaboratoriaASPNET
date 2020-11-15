﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NewBrandingStyleWeb.Entities;

namespace NewBrandingStyleWeb.Database
{
    public class ExchangesDbContext : DbContext
    {
        public ExchangesDbContext(DbContextOptions options) : base(options)
        { 
        }
        public DbSet<ItemEntity> Items { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            // fluent configuration
        }
    }
}
