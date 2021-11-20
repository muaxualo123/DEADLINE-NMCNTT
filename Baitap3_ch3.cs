/*3.	Viết chương trình nhập vào điểm ba môn Toán, Lý, Hóa của một học sinh. In ra điểm trung bình của học sinh đó với hai số lẻ thập phân.
do phan duy hùng
cd21tt11
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt3ch3
{
    class Program
    {
        static void Main(string[] args)
        {
            double Toan = 0;
            double Ly = 0;
            double Hoa = 0;
            double diemtrungbinh = 0;
            Console.WriteLine("toan", Toan);
            Toan = double.Parse(Console.ReadLine());
           
            
            Console.WriteLine("ly",Ly);
            Ly = double.Parse(Console.ReadLine());
            Console.WriteLine("hoa",Hoa);
            Hoa = double.Parse(Console.ReadLine());
            
            Console.WriteLine($"diemtrungbinh = {(Toan + Ly + Hoa) / 3}",diemtrungbinh);
            Console.ReadKey();
        }
    }
}
