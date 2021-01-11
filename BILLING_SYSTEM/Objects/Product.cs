using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BILLING_SYSTEM.Objects
{
    class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public int added_by { get; set; }
        public decimal rate { get; set; }
        public decimal qty { get; set; }
        public decimal total { get; set; }

        public Product(string name, decimal rate, decimal qty, decimal total)
        {
            this.name = name;
            this.rate = rate;
            this.qty = qty;
            this.total = total;
        }

        public Product()
        {
        }
    }
}
