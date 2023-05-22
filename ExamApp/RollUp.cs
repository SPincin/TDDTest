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
            int lowestGtinPrice = int.MaxValue;
            int lowestVariantPrice = int.MaxValue;

            foreach (Input input in inputs)
            {
                string gtin = input.GTin.Code;
                string variant = input.Variant.Code;
                int price = input.Price;

                if (gtin != variant && price < lowestGtinPrice)
                {
                    lowestGtinPrice = price;
                }

                if (price < lowestVariantPrice)
                {
                    lowestVariantPrice = price;
                }
            }

            Output result = new Output
            {
                Product = inputs[0].Product.Code,
                Price = lowestVariantPrice
            };

            return result;
        }




    }
}
