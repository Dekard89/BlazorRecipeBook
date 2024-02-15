using BookOfRecipe.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataContext
{
    public class AppContext : DbContext
    {
        public DbSet<RecipeDTO> Recipes { get; set; }

        public DbSet<IngredientDTO> Ingredients { get; set;}

        public DbSet<TopingDTO> Topings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder()
                        .AddJsonFile("appsettings.json")
                        .SetBasePath(Directory.GetCurrentDirectory())
                        .Build();

            optionsBuilder.UseNpgsql(config.GetConnectionString("Postgres"));
        }
    }
}
