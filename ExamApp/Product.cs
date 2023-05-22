using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamApp
{
    public class Product
    {
        public string Code { get; set; }
        public decimal Price { get; set; }
        public List<Variant> Variants { get; set; }

        public Product()
        {
            Variants = new List<Variant>();
        }
    }
}
