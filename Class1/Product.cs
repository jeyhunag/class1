using System;
using System.Collections.Generic;
using System.Text;

namespace Classlar
{
    public class Product
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime DateOfExpiration { get; set; }
        public string Type { get; set; }
        public int Weight { get; set; }
        public string Color { get; set; }
        public int Size { get; set; }
        public float price { get; set; }
        public int units { get; set; }

        public void Mehsulunxasseleri()
        {
            Console.WriteLine("Mehsulun adinin daxil edin:"+Name);
            Console.WriteLine("Mehsulun ID daxil edin:"+ID);
            Console.WriteLine("Mehsulun novunu daxil edin:"+Type);
            Console.WriteLine("Mehsulun rengini daxil edin:"+Color);
            Console.WriteLine("Mehsulun olcusunu daxil edin:"+Size);
            Console.WriteLine("Mehsulun qiymetini daxil edin:"+price);


           
        }

    }
    

}