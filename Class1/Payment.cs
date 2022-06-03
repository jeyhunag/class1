using System;
using System.Collections.Generic;
using System.Text;

namespace Class
{
    public class Payment
    {
        public int CashPayment { get; set; }
        public decimal Balance { get; set; }
        public int CustomerID { get; set; }
        public Customer Customer { get; set; }
        public int EmployeeID { get; set; }
        public Employee Employee { get; set; }




    }

}
