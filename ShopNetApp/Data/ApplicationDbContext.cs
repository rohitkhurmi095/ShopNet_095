﻿using Microsoft.EntityFrameworkCore;
using ShopNetApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopNetApp.Data
{
    //==========
    //DbContext
    //==========
    //EntityFramework Migrations:
    //add-migration "migrationName" -o Data/Migrations
    //update-database
    public class ApplicationDbContext : DbContext
    {
        //Pass ApplicationDbContext options -> EF Core DbContext
        //query data using DbContext instance
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }


        //======
        //DbSet (Tables in Database)
        //======
        public DbSet<Category> Category { get; set; }
    }
}
