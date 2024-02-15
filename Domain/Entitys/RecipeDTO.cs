using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entitys
{
    public class RecipeDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public Category Category { get; set; }
        public string ImagePath { get; set; }

        public string Description { get; set; }
        public List<IngredientDTO> Ingredients { get; set; } = new();
        public List<TopingDTO> Topings { get; set; } = new();
    }
}
