﻿using ConvergedConnector.Data.Entities;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConvergedConnector.Data
{
    
    public class PlatformContext : DbContext
    {
        public PlatformContext(DbContextOptions<PlatformContext> options): base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
