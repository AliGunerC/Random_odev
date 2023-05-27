using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random i = new Random();
            int a;
            a = i.Next(1, 100);

            int hak = 5; 

            while (hak > 0)
            {
                Console.WriteLine("lütfen 1 ile 100 arası sayı girin");
                int sayi_gir = Convert.ToInt32(Console.ReadLine());

                if (sayi_gir > a)
                {
                    Console.WriteLine("Daha küçük");
                    hak -= 1;
                    Console.WriteLine("Yeni hak:"+hak);
                }
                else if (sayi_gir < a )
                {

                    Console.WriteLine("Daha büyük");
                    hak -= 1;
                    Console.WriteLine("Yeni hak:" + hak);


                }
                else if (sayi_gir == a)
                {
                    Console.WriteLine("tebrikler dogru sayıyı bildiniz çıkmak için a harfine basın");
                    string harf = Convert.ToString(Console.ReadLine());
                    if (harf == "a" )
                    {
                        break;
                    }
                }
                

            }

        }
    }
}
