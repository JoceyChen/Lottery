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
            // 產生亂數
            Random rand = new Random();

            int i = 1;
                                    
            while (i<11)
            {
                int n1 = rand.Next(1, 43);
                int n2 = rand.Next(1, 43);
                int n3 = rand.Next(1, 43);
                int n4 = rand.Next(1, 43);
                int n5 = rand.Next(1, 43);
                int n6 = rand.Next(1, 43);
                
                i++;

                // 顯示亂數
                Console.WriteLine("第"+(i-1)+"組號碼:"+"{0:00} {1:00} {2:00} {3:00} {4:00} {5:00}", n1, n2, n3, n4, n5, n6);
            }
                                   

            // 暫停並顯示
            Console.ReadLine();
        }
    }
}
