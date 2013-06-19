using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POS
{
    class ProductPopulate
    {
        
      
        public string ProductName;
        public string CategoryName;
        public double Price;

        public ProductPopulate(string ProductName, string CategoryName, double Price)
        {
            this.ProductName = ProductName;
            this.CategoryName = CategoryName;
            this.Price = Price;
           
            
        }
    }
}
