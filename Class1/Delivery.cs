using Classlar;
using System;
using System.Collections.Generic;
using System.Text;

namespace Class
{
    public class Delivery
    {
        public int DeliveryID { get; set; }
        public string DeliveryAdress { get; set; }
        public int MyProperty { get; set; }
        public int ProductID { get; set; }
        public Product Product { get; set; }
        public int CustomerID { get; set; }
        public Customer Customer { get; set; }
        public int OrderID { get; set; }
        public Order Order { get; set; }
    }
}
