using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Goodbye
{
    class Sinhvien
    {
        static void Main(string[] args)
        {
            Method1();
            Method2();
            Console.ReadKey();
        }

        public static async Task Method1()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine(" Method 1");
                }
            });
        }


        public static void Method2()
        {
            for (int i = 0; i < 25; i++)
            {
                Console.WriteLine(" Method 2");
            }
        }

        public static void Method3()
        {
            for (int i = 0; i < 25; i++)
            {
                Console.WriteLine(" Method 2");
            }
        }
        public static void Method4()
        {
            for (int i = 0; i < 25; i++)
            {
                Console.WriteLine(" Method 2");
            }
        }

    }

}
