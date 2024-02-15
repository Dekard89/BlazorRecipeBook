using Domain.Entitys;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Context:DbContext
    {
        public DbSet<RecipeDTO> Recipes { get; set; }

        public DbSet<IngredientDTO> ingredients { get; set; }

        public DbSet<TopingDTO> Topings { get; set; }

        public Context()
        {
                
        }
        public Context(DbContextOptions<Context> options):base(options) 
        {
            Database.Migrate();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=BoR.db");
        }
    }
}
