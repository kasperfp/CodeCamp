using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CubrisProject.Models
{
    public class ThemeParkContext : DbContext
    {
        public ThemeParkContext(DbContextOptions<ThemeParkContext> options)
            : base(options)
        {
        }

        public DbSet<ThemePark> ThemeParks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=themepark.db");
        }
    }
}
