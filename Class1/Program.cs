using Classlar;
using System;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sexsiyyetiniz");

            Person kimliyiniz = new Person();
            kimliyiniz.ID = 25;
            kimliyiniz.Name = "Cavid";
            kimliyiniz.Surname = "Eliyev";
            kimliyiniz.Email = "Blog@gmail.com";
            kimliyiniz.Age = 26;
            kimliyiniz.Haqqinizda();
            Console.ReadLine();


            Console.WriteLine("Satici haqqinda melumat");
            Employee Satici = new Employee();
            Satici.ID = 28;
            Satici.Salany = 1880;
            Satici.password = 15485;
            Satici.loginName = "Villain";
            Satici.Iski();
            Console.ReadLine();



            Console.WriteLine("Aldiginiz mehsul");
            Product Mehsul = new Product();
            Mehsul.Name = "Qarpiz";
            Mehsul.ID = 54;
            Mehsul.Type = "Meyve";
            Mehsul.Color = "Yasil";
            Mehsul.Size = 48;
            Mehsul.price = 22;

            Mehsul.Mehsulunxasseleri();
            Console.ReadKey();

        }


    }
}
