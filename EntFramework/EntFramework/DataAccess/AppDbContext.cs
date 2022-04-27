using EntFramework.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntFramework.DataAccess
{
    class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-ULBGA9L\SQL;Database=Offices;Integrated Security=true;");
        }
        public DbSet<Employee> employees { get; set; }
    }
}
