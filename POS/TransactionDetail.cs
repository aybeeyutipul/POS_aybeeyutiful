using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POS
{
    public class TransactionDetail
    {
        public int TransactionDetailId { get; set; }
        public int TransactionId { get; set; }
        public int ProductId { get; set; }
        public double Quantity { get; set; }
    }
}
