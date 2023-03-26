using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace my_repo_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine ("Hesap Makinesi");

            Console.WriteLine("Bir sayi  giriniz");
            double sayi1 = int.Parse(Console.ReadLine());

            Console.WriteLine(" Islem Seciniz (+) (-) (*) (/) (%) :");
           string islem = (Console.ReadLine());

            Console.WriteLine("Bir     sayi    giriniz");
            double sayi2 = int.Parse(Console.ReadLine());

            double sonuc = 0;


           
            switch(islem)
            {
                case "+": sonuc = sayi1+sayi2;   break;
                case "-": sonuc = sayi1-sayi2;   break;
                case "*": sonuc = sayi1*sayi2;   break;
                case "/": sonuc = (sayi1/sayi2); break;
                case "%": sonuc = (sayi1%sayi2); break;
                 // Console.WriteLine("{0} {1} {2}={3}");

              Console.WriteLine(sayi1 +" "+ islem+" "+sayi2 + " "+ sonuc );

                    Console.WriteLine();



            }


        }
    }
}
