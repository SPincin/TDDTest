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
            int lowestGtinPrice = inputs[0].GTin.Price;
            Variant lowestVariant = inputs[0].Variant;

            foreach (Input input in inputs)
            {
                int gtinPrice = input.GTin.Price;
                Variant variant = input.Variant;

                if (gtinPrice < lowestGtinPrice)
                {
                    lowestGtinPrice = gtinPrice;
                    lowestVariant = variant;
                }
                else if (gtinPrice == lowestGtinPrice && variant.Price < lowestVariant.Price)
                {
                    lowestVariant = variant;
                }
            }

            Output result = new Output
            {
                Product = lowestVariant.Product.Code,
                Price = lowestVariant.Price
            };

            return result;
        }







    }
}
