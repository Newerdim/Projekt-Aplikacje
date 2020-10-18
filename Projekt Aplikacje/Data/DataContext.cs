﻿using Microsoft.EntityFrameworkCore;
using Projekt_Aplikacje.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt_Aplikacje.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) 
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Gender>().HasData(
                new Gender { Id = 1, Name = "Mężczyzna" },
                new Gender { Id = 2, Name = "Kobieta" }
                );
        }

        public Gender Genders { get; set; }
    }
}