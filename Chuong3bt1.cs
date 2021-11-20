using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chuong3_bt1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int c = 0;
            Console.WriteLine("nhap a: ",a);
            a =int.Parse(Console.ReadLine());
            Console.WriteLine("nhap b: ", b);
            b =int.Parse(Console.ReadLine());
            Console.WriteLine($"+ :c={c = a + b}");
            Console.WriteLine($"- :c={c = a - b}");
            Console.WriteLine($"* :c={c = a * b}");
            Console.WriteLine($"/: c={c = a / b}");
            Console.ReadKey();


        }
    }
}
