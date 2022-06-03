using System;
using System.Collections.Generic;
using System.Text;

namespace Class
{
    public class Employee : Person
    {
        public int EmID { get; set; }
        public float Salany { get; set; }
        public decimal department { get; set; }
        public int password { get; set; }
        public string loginName { get; set; }

        public void Iski()
        {
            Console.WriteLine("Id unvani:" + EmID);
            Console.WriteLine("Emekhaqqiniz:" + Salany);
            Console.WriteLine("Sifreniz:" + password);
            Console.WriteLine("Istifadeci adiniz:" + loginName);
        }
    }
}
