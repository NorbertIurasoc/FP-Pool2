using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool2_Prob3
{
    class Program
    {
        static void Main(string[] args)
        {
            int  sum = 0;

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                sum = sum + i;
                sum++;
             
            }

            int pro = 0;
            for (int i = 0; i < n; i++)
            {   

                pro = pro * i;
                pro++;


            }



            Console.WriteLine("Suma numerelor este: " + sum);
            Console.WriteLine("Produsul numerelor este: " + pro);
            
            
            Console.ReadKey();
        }
    }
}
