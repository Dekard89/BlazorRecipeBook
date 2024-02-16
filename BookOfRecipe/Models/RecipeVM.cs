using Domain.Entitys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookOfRecipe.Models
{
    public class RecipeVM
    {
        public int ID { get; set; }

        [Required(ErrorMessage ="Поле обязательно для ввода")]
        [MaxLength(50),MinLength(2)]
        [DisplayName("Введите название")]
        public string Name { get; set; }

        public string ImagePath { get; set; }


        [Required(ErrorMessage = "Поле обязательное для ввода")]
        [DisplayName("Выберите категорию")]
        public CategoryVM Category { get; set; }

        [DisplayName("Опишите процесс приготовления")]
        public string Description { get; set; }

        public List<IngredientVM> Ingredients { get; set;}=new();

        public List<IngredientVM> Topings { get; set; } = new();

        public bool IsAcive { get; set; }

        public RecipeVM()
        {
            
        }
        public RecipeVM(RecipeDTO dto)
        {
            
            ID = dto.Id;
            Name = dto.Name;
            ImagePath = dto.ImagePath;
            Category=(CategoryVM)dto.Category;
            Description = dto.Description;
            IsAcive = dto.IsActive;
        }
    }
}
