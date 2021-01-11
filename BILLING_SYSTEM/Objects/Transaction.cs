using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BILLING_SYSTEM.Objects
{
    class Transaction
    {
        public int id { get; set; }
        public string type { get; set; }
        public int customerId { get; set; }
        public decimal grandTotal { get; set; }
        public DateTime date { get; set; }
        public decimal vat { get; set; }
        public decimal discount { get; set; }
        public int added_by { get; set; }
    }
}
