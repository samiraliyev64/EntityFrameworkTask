using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework.DataAccess
{
    class AppDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-FJ28S1F;Database=CompanyDb;Integrated Security=true;");
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
