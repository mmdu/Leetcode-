using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _461HammingDistance
{
    class Program
    {
        internal int HammingtonDistance(int x, int y)
        {
            int count = 0;
            int res = x ^ y;

            for (int i = 0; i < 31; i++)
            {
                if ((res & (1 << i)) == (1 <<i))
                    count++;
                else
                    continue;

            }
         
            return count;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("please input first number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please input second number");
            int b = Convert.ToInt32(Console.ReadLine());
            Program P = new Program();
            int c = P.HammingtonDistance(a, b);

            Console.WriteLine(c);

        }

       
    }

     
}
