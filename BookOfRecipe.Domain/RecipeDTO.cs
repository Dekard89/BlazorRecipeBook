using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookOfRecipe.Domain
{
    public class RecipeDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string imagrPath { get; set; }

        public bool IsActive { get; set; }

        public Category Category { get; set; }

        public string Description { get; set; }

        public List<IngredientDTO> Ingredients { get; set; }=new List<IngredientDTO>();

        public List<TopingDTO> Topings { get; set; } = new List<TopingDTO>();
    }
}
