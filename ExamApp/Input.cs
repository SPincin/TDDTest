using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ExamApp
{
    public class Input
    {
        public GTin GTin { get; set; }
        public Variant Variant { get; set; }
        public Product Product { get; set; }
        public int Price { get; set; }

        public Input(GTin gtin, Variant variant, Product product, int price)
        {
            GTin = gtin;
            Variant = variant;
            Product = product;
            Price = price;
        }
    }
}
