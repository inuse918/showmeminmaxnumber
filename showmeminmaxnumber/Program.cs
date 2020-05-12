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
            int temp;
            for(int i = 0; i < input.Length; i++)
            {
                Console.Write("숫자를 입력해주세요: ");
                input[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("----------------------");
            
            for(int i = 0; i < input.Length-1; i++)
            {
                for(int j = i+1; j < input.Length; j++)
                {
                    if (input[i] > input[j])
                    {
                        temp = input[i];
                        input[i] = input[j];
                        input[j] = temp; 
                    }
                }
            }

            Console.WriteLine("가장 큰 수: "+input[4]);
            Console.WriteLine("가장 작은 수: " + input[0]);
            //Console.WriteLine(num);
        }
    }
}
