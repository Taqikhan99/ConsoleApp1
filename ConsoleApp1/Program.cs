using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;

            Console.WriteLine("Please Enter a number: ");
            try
            {
                a = Convert.ToInt32(Console.ReadLine());
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(a+" * "+i+" = "+a*i);
                }
            }
            catch
            {
                Console.WriteLine("Please Enter a valid number");
            }
            

        }
    }
}
