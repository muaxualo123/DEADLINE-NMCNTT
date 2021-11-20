/*2.	Viết chương trình đọc vào độ F, tính và in ra độ C theo công thức như sau:
C = ((F – 32) * 5) / 9.
đỗ phan duy hùng
cd21tt11
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt2ch3
{
    class Bt2_chuog3
    {
        static void Main(string[] args)
        {
            double F = 0;
            double C = 0;
            //cong thuc C = ((F – 32) * 5) / 9
            Console.WriteLine("nhap do F =");
            F = double.Parse(Console.ReadLine());
            Console.WriteLine($"do C = {((F - 32) * 5) / 9}", C);
            Console.ReadKey();
        }
    }
}
