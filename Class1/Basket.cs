using System;
using System.Collections.Generic;
using System.Text;

namespace Class
{
    public class Basket
    {
        public int BasketID { get; set; }
        public int TaxTotal { get; set; }
        public int Total { get; set; }
        public int TrackingNumber { get; set; }
        public int OrderID { get; set; }
        public Order Order { get; set; }
        public int Units { get; set; }
    }
}
