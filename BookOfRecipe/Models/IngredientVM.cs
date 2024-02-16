using Domain.Entitys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage.Search;

namespace BookOfRecipe.Models
{
    public class IngredientVM
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Поле обязательное для ввода")]
        [MaxLength(50), MinLength(2)]
        [DisplayName("Введите название")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Поле обязательное для ввода")]
        [DisplayName("Введите стоимость")]
        public double Price { get; set; }

        public int Qty { get; set; }

        [Required(ErrorMessage = "Поле обязательное для ввода")]
        [DisplayName("Выберите категорию")]
        public CategoryVM Category { get; set; }

        public bool IsToping { get; set; }

        public List<RecipeVM> Recipes { get; set; } = new List<RecipeVM>();

        public double TotalPrice 
        {
            get => TotalPrice;
            set => TotalPrice = Qty * Price;
        }
        public IngredientVM()
        {
            
        }
        public IngredientVM(IngredientDTO dto)
        {
            ID=dto.Id;
            Name = dto.Name;
            Price = dto.Price;
            Qty = dto.Qty;
            IsToping = dto.IsToping;
            Category=(CategoryVM)dto.Category;
        }
    }
}
