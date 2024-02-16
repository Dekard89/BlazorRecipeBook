using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entitys
{
    public class IngredientDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Qty { get; set; }
        public bool IsToping { get; set; }
        public Category Category { get; set; }
        public List<RecipeDTO> Recipes { get; set; } = new();
    }
}
