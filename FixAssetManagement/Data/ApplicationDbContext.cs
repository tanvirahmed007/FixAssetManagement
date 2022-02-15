﻿using FixAssetManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace FixAssetManagement.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Department> Departments { get; set; }

       
        public DbSet<Employee> Employees { get; set; }
    }
}