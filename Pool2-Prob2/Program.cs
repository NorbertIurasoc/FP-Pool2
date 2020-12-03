using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool2_Prob2
{
    class Program
    {
        static void Main(string[] args)
        {
            int negativ = 0, zero = 0, pozitiv = 0, x;

            Console.WriteLine("Introduceti cate numere sa fie: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());
                if (x == 0)
                {
                    zero++;

                   
                }
                if (x > 0)
                {
                    pozitiv++;
                }
                if (x < 0)
                {
                    negativ++;
                }
            }


            Console.WriteLine("negative sunt: " + negativ);
            Console.WriteLine("zero sunt: " + zero);
            Console.WriteLine("pozitive sunt: " + pozitiv);






            Console.ReadKey();
        }
    }
}
