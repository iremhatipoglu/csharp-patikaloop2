using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whilePatika
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sayı giriniz :");
            int a = int.Parse(Console.ReadLine());
            int b = 1;
            int c = 0;
            while (b <= a)
            {
                c += b;
                b++;
            }
            Console.WriteLine(c / a);
            Console.WriteLine("************************");
            char e = 'a';
            while (e < 'z')
            {
                Console.WriteLine(e);
                e++;

            }
            Console.WriteLine("************************");
            string[] ogrenci = { "Selen", "İrem", "Gurur", "Beyza" };

            foreach (var i in ogrenci)
            {
                Console.WriteLine(i);
            }

        }
    }
}
