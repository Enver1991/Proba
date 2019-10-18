using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karakter
{
    class Program
    {
        static void Main(string[] args)
        {
          

            Console.WriteLine("Uneti opseg Karaktera ");

            Console.Write("od: ");

            char Karakter = (char)(int.Parse(Console.ReadLine()));

            Console.Write("do: ");

            char kaarakter = (char)(int.Parse(Console.ReadLine()));

            Console.WriteLine("Koliko Karaktera po redu? ");

            int karakter =(int.Parse(Console.ReadLine()));

            while (Karakter <= kaarakter)
            {
                Console.Write(Karakter);
                if ((Karakter - 126 ) % karakter == 0 )
                {
                    Console.WriteLine();
                }
                
                Karakter++;
            }

            Console.ReadKey();

        }
    }
}
