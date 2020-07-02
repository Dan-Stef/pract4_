using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Console.WriteLine("First task");
                Console.Write("Input the value: ");
                int n = Convert.ToInt32(Console.ReadLine());
                if (n <= 0) throw new Exception("The value cant be negative");
                int a = f(n);
                if (Math.Pow(2, a - 1) <= n && n <= Math.Pow(2, a)) Console.WriteLine("The a is " + a);
                else Console.WriteLine("The a is " + a + ". But " + n + " is not between " + Math.Pow(2, a - 1) + " and " + Math.Pow(2, a));
                Console.WriteLine("---------------------------");
                Console.WriteLine("Second task");
                Console.Write("Input the value: ");
                int k = Convert.ToInt32(Console.ReadLine());
                if (k <= 0) throw new Exception("The value cant be negative");
                rec(k);
                Console.ReadKey();
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Incorrect input of value");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        static int f(int n)
        {
            if (n == 1) return 1;
            else return (f(n / 2) + 1);
        }
        static void rec(int k)
        {
            for (int i = 1; i <= k; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();

            }
        }
    }
}
