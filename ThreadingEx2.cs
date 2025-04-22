using System;

namespace ThreadingEx2
{
    internal class Program
    {
        static void Main0(string[] args)
        {
            Thread t1 = new Thread(new ParameterizedThreadStart(fun1));
            t1.Start("T1 Paased value");
            
            Thread t2 = new Thread((fun2));
            t2.Start("T2 value is given");
        }

        static void Main()
        {
            int[] arr =new int[2];
            arr[0] = 10;
            arr[1] = 20;

            Thread t3 = new Thread((fun3));
            t3.Start(arr);
        }

        static void fun1(object obj)
        {
            for (int i = 101; i < 110; i++)
            {
                Console.WriteLine("First fun :" + i + obj.ToString());
            }
        }

        static void fun2(object obj)
        {
            for (int i = 1; i < 110; i++)
            {
                Console.WriteLine("Second fun :" + i + obj.ToString());
            }
        }

        static void fun3(object obj)
        {
            int[] arr = (int[])obj;
            Console.WriteLine(arr[0]);
            Console.WriteLine(arr[1]);
        }

    }
}
