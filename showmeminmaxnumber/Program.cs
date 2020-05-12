using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace showmeminmaxnumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = new int[5];
            for(int i = 0; i < 5; i++)
            {
                Console.Write("숫자를 입력해주세요: ");
                input[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("----------------------");
            

            //Console.WriteLine(num);
        }
    }
}
