using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppalgoritma
{
    class Program
    {
        static void Main(string[] args)
        {

            int n; Console.Write("Bir sayı adedi gir:");
            n = Convert.ToInt32(Console.ReadLine());
            int btoplam = 0, ctoplam = 0, ktoplam = 0, b = 0, c = 0, k = 0;

            while (1<n)
            {

            
            for (int x = 1; x <= n; x++)
            {
                int s; Console.Write("Bir sayı  gir:");
                s = Convert.ToInt32(Console.ReadLine());

                if (s % 5 == 0)
                {
                    b = b + 1;
                    btoplam = btoplam + s;

                }
                if (s % 3 == 0)
                {
                    c = c + 1;
                    ctoplam = ctoplam + s;

                }
                if (s % 2 == 0)
                {
                    k = k + 1;
                    ktoplam = ktoplam + s;

                }
                }

            }
            Console.WriteLine("5 ile bölünebilenlerin adeti " + b);
            Console.WriteLine("3 ile bölünebilenlerin adeti " + c);
            Console.WriteLine("2 ile bölünebilenlerin adeti " + k);
            Console.WriteLine("5 ile bölünebilenlerin toplamı " + btoplam);
            Console.WriteLine("3 ile bölünebilenlerin toplamı " + ctoplam);
            Console.WriteLine("2 ile bölünebilenlerin toplamı " + ktoplam);
            Console.ReadLine();

        }
    }
}
