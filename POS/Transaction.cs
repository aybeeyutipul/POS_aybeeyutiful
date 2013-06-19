using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POS
{
    public class Transaction
    {
        public int TransactionId { get; set; }
        public int EmployeeId { get; set; }
        public double Price { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
