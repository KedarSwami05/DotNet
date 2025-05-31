namespace WorkingWithTasks
{
    internal class Program
    {
        static void Main1()
        {
            Task t1 = new Task(Fun1);
            Task t2 = new Task(Fun2);
            t1.Start();
            t2.Start();
            //t1.Wait();
            Console.ReadLine();
        }

         static void Fun1()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("First :" + i);
            }
        }

        static void Fun2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Second fun called from  {0},{1}", Thread.CurrentThread.ManagedThreadId, i);
            }
        }
    }
}

namespace Example2
{
    internal class Program
    {
        static void Main2()
        {
            Task t1 =  Task.Run(Fun1);              // dont need to start task it start automatically
            Task t2 =  Task.Factory.StartNew(Fun2);
            
            //t1.Wait();
            Console.ReadLine();
        }

        static void Fun1()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("First :" + i);
            }
        }

        static void Fun2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Second fun called from  {0},{1}", Thread.CurrentThread.ManagedThreadId, i);
            }
        }
    }
}


namespace Example3
{
    internal class Program1
    {
        static void Main3()
        {
            Task t1 = new Task(Fun1, "Passed value");              // dont need to start task it start automatically
            Task t2 = Task.Factory.StartNew(Fun2, "aaaaaaaa");

            string s = "ccccc";

            Task.Run(delegate () { Console.WriteLine(s); });
            Task.Run(() => { Console.WriteLine(s); });
            //t1.Wait();
            Console.ReadLine();
        }


        static void Fun1(Object obj)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("First :" + i);
            }
        }

        static void Fun2(Object obj)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Second fun called from  {0},{1}", Thread.CurrentThread.ManagedThreadId, i);
            }
        }
    }
}

namespace Example4
{
    internal class Program1
    {
        static void Main4()
        {
            Task <int> t1 = new Task<int>(Fun1,"passed value");              // dont need to start task it start automatically
            t1.Start();
            Console.WriteLine("Code before result ");

            Console.WriteLine(t1.Result);
            Console.ReadLine();
        }


        static int Fun1(Object obj)
        {
            int i;
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("First :" + i);
            }
            return i;
        }

        static void Fun2(Object obj)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Second fun called from  {0},{1}", Thread.CurrentThread.ManagedThreadId, i);
            }
        }
    }
}

namespace Example5
{
    internal class Program1
    {
        static void Main()
        {
            Task<int> t1 = new Task<int>(Fun2, "passed value t2");              // dont need to start task it start automatically
            t1.Start();
            Task<int> t3 = new Task<int>(Fun2, "passed value t3");
        

            Console.WriteLine(t1.Result); //waiting call
            Console.WriteLine(t3.Result);
            Console.ReadLine();
        }


        static int Fun1(Object obj)
        {
            int i;
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("First :" + i);
            }
            return i;
        }

        static int Fun2(Object obj)
        {
            int i;
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("Second fun called from  {0},{1}", i, obj.ToString());
            }
            return i;
        }
    }
}




