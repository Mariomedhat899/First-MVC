﻿using Company.G02.DAL.Modules;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Company.G02.DAL.Data.Contexts
{
    public class CompanyDbContext :DbContext
    {
        public CompanyDbContext() :base()
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            optionsBuilder.UseSqlServer("Server = . ; DataBase = Company.G02 ; Trusted_Connection = True ; TrustServiceCertificate = True");
        }

        public DbSet<Department> Departments { get; set; }
    }
}
