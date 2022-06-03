using System;
using System.Collections.Generic;
using System.Text;

namespace Class
{
    public class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FatherName { get; set; }
        public DateTime Dateofbirth { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public int[] Phone { get; set; }

        public void Haqqinizda()
        {
            Console.WriteLine("ID nomreniz:" + ID);
            Console.WriteLine("Adiniz:" + Name);
            Console.WriteLine("Soyadini:" + Surname);
            Console.WriteLine("Email unvaniniz:" + Email);
            Console.WriteLine("Sifreniz:" + Password);
            Console.WriteLine("Yasiniz:" + Age);

        }


    }
}
