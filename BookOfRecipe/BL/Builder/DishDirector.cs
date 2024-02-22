using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookOfRecipe.BL.Builder
{
    public class DishDirector
    {
        private readonly IDishBuilder _dishBuilder;

        public DishDirector(IDishBuilder dishBuilder) 
        {
            _dishBuilder = dishBuilder;
        }

        public Dish CookWithoutToping()
        {
            _dishBuilder.BuidMain().BuidPrice();

            return _dishBuilder.GetDish();
        }
        public Dish CookWithFirstToping()
        {
            _dishBuilder.BuidMain().BuidPrice().AppenFirstToping();

            return _dishBuilder.GetDish();
        }
        public Dish CookWithSecondToping()
        {
            _dishBuilder.BuidMain().BuidPrice().AppendSecondToping();

            return _dishBuilder.GetDish();
        }
        public Dish CookWithThirdToping()
        {
            _dishBuilder.BuidMain().BuidPrice().AppendThirdToping();

            return _dishBuilder.GetDish();
        }
        public Dish CookWithFirstAndSecondToping()
        {
            _dishBuilder.BuidMain().BuidPrice().AppenFirstToping().AppendSecondToping();

            return _dishBuilder.GetDish();
        }
        public Dish CookWithFirstAndThirdToping()
        {
            _dishBuilder.BuidMain().BuidPrice().AppenFirstToping().AppendThirdToping();

             return _dishBuilder.GetDish();
        }
        public Dish CookWithSecondAndThirdToping()
        {
            _dishBuilder.BuidMain().BuidPrice().AppendSecondToping().AppendThirdToping();

            return _dishBuilder.GetDish();
        }
        public Dish CookWithAllToping()
        {
            _dishBuilder.BuidMain().BuidPrice().AppenFirstToping().AppendSecondToping().AppendThirdToping();

            return _dishBuilder.GetDish();
        }
    }
}
