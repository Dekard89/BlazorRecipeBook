using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookOfRecipe.BL.Builder
{
    public interface IDishBuilder
    {
        public IDishBuilder BuidMain();

        public IDishBuilder BuidPrice();

        public IDishBuilder AppenFirstToping();

        public IDishBuilder AppendSecondToping();

        public IDishBuilder AppendThirdToping();

        public Dish GetDish();
    }
}
