using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool2_Prob1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti cate numere sa fie: ");
            int n = int.Parse(Console.ReadLine());
            int x;
            int nrpar = 0;
            
            for (int i = 0; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());
                if (x % 2 == 0)
                    nrpar++;
            }


            if ( nrpar == 0)
            {
                Console.WriteLine("NU EXISTA!");
            }
            else
            {
                Console.WriteLine(nrpar);
            }

            Console.ReadKey();
        }
    }
}
