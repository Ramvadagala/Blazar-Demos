using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Sum(10, 20);
            Console.Read();
        }
        public static int Sum(int num1, int num2)
        {
            try
            {
                int total;
                total = num1 + num2;
                Console.WriteLine(total);
                return total;
            }
            catch (Exception ex)
            {
                return int.Parse(" 404 Bad Request");
            }
        }
    }
}

