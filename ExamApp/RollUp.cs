using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamApp
{
    public class RollUp
    {
        public Output RollUpMethod(List<Input> inputs)
        {
            int g1Price = inputs[0].Price;
            int g2Price = inputs[1].Price;
            int g3Price = inputs[2].Price;
            int g4Price = inputs[3].Price;

            int lowestGPrice = Math.Min(g1Price, g2Price);
            int lowestVPrice = Math.Min(g3Price, g4Price);

            Output result = new Output
            {
                Product = inputs[0].Product.Code,
                Price = Math.Min(lowestGPrice, lowestVPrice)
            };

            return result;
        }








    }
}
