using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1021ora
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            var t = new int[10];
            for (int i = 0; i < t.Length; i++)
            {
                t[i] = rnd.Next(10, 100);
                Console.WriteLine($"{t[i]},");

            }
            Console.ReadKey();
        }
    }
}
