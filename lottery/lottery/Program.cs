using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lottery
{
    class Program
    {
        static void Main(string[] args)
        {
            //創建亂數
            Random rand = new Random();

            //顯示亂數
            Console.WriteLine(rand.Next(0, 100));

            //結束
            Console.ReadLine();
        }
    }
}
