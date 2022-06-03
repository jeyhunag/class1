using Classlar;
using System;
using System.Collections.Generic;
using System.Text;

namespace Class
{
    public class Order
    {
        public int ShippingTotal { get; set; }
        public string StatusCode { get; set; }
        public Product Product { get; set; }
        public Category Category { get; set; }
        public Customer Customer { get; set; }
    }
}
