using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamApp
{
    public class Variant
    {
        public string Code { get; set; }
        public decimal Price { get; set; }
        public List<GTin> GTins { get; set; }

        public Variant()
        {
            GTins = new List<GTin>();
        }
    }
}
