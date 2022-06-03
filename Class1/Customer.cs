using System;
using System.Collections.Generic;
using System.Text;

namespace Class
{
    public class Customer : Person
    {
        public string Accaunts { get; set; }
        public string CustomerType { get; set; }
        public int PaymenID { get; set; }
        public Payment Payment { get; set; }

    }
}
