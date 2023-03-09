using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyFirstEfCoreApp.Models;

namespace MyFirstEfCoreApp.Date
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = MyFirstEfCore.db");
        }

        public DbSet<Book> Books { get; set; }
    }
}