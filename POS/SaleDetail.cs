using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POS
{
    public class SaleDetail
    {
        public int SaleDetailId { get; set; }
        public int SaleId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
