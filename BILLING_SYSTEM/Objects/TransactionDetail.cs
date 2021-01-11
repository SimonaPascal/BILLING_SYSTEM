using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BILLING_SYSTEM.Objects
{
    class TransactionDetail
    {
        public int id { get; set; }
        public int productId { get; set; }
        public decimal rate{ get; set; }
        public decimal qty { get; set; }
        public DateTime addedDate { get; set; }
        public decimal total { get; set; }
        public int customerId { get; set; }
        public int added_by { get; set; }
        public string type { get; set; }
    }
}
