using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POS
{
    public class Sale
    {
        public int SaleId { get; set; }
        public DateTime Date { get; set; }
        public string Total { get; set; }        
        public int UserId { get; set; }
    }
}
