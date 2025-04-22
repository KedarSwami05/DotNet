namespace ThreadingEx
{
    internal class Program
    {
       
        static void Main0(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(fun1)); //here thread is created
            t1.Start(); // thead start here   //ThreadStart is Deligate 

            Thread t2 = new Thread((fun2)); //simple way to write deligate
            t2.Start();

            //fun1();
            //fun2();

            for (int i = 201; i < 210; i++)
            {
                Console.WriteLine("main code :" +i);
            }
        }

        static void Main1(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(fun1)); //here thread is created
            t1.IsBackground = true;   
            t1.Start(); // thead start here   //ThreadStart is Deligate 

            Thread t2 = new Thread((fun2)); //simple way to write deligate
            t2.IsBackground = true;
            t2.Start();

            //fun1();
            //fun2();

            for (int i = 201; i < 210; i++)
            {
                Console.WriteLine("main code :" + i);
            }
        }

        static void Main2(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(fun1)); 
       
            Thread t2 = new Thread((fun2));

            t1.Start();
            t2.Start();

           

            for (int i = 201; i < 210; i++)
            {
                Console.WriteLine("main code :" + i);
            }
            t1.Join(); //waiting call
            Console.WriteLine("Join : code to call after fun1 is over");
        }

        static void Main3(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(fun1));

            Thread t2 = new Thread((fun2));

            t1.Priority = ThreadPriority.Highest;  
            t2.Priority = ThreadPriority.Lowest;

            t1.Start();
            t2.Start();



            for (int i = 201; i < 210; i++)
            {
                Console.WriteLine("main code :" + i);
            }
            t1.Join(); //waiting call
            Console.WriteLine("Join : code to call after fun1 is over");
        }

        static void Main4(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(fun1));

            Thread t2 = new Thread((fun2));

            if (t1.ThreadState == ThreadState.Unstarted)
                t1.Start();

                t2.Start();
                        



            for (int i = 201; i < 210; i++)
            {
                Console.WriteLine("main code :" + i);
            }

            t1.Join(); //waiting call
            Console.WriteLine("Join : code to call after fun1 is over");
        }

        static void Main(string[] args)
        {
            AutoResetEvent wh = new AutoResetEvent(false);

            Thread t1 = new Thread(delegate ()
            {
                for (int i = 0; i < 200; i++)
                {
                    Console.WriteLine("F1:" + i);
                    if (i % 50 == 0)
                    {
                        Console.WriteLine("Waiting");
                        wh.WaitOne();  //wait until the signal comes
                    }
                }
            });

            t1.Start();
            Thread.Sleep(5000);
            //Console.ReadLine();
            Console.WriteLine("resuming 1");
            wh.Set();

            
            Thread.Sleep(5000);
            //Console.ReadLine();
            Console.WriteLine("resuming 2");
            wh.Set();

          
            Thread.Sleep(5000);
            //Console.ReadLine();
            Console.WriteLine("resuming 3");
            wh.Set();

         
            Thread.Sleep(5000);
            //Console.ReadLine();
            Console.WriteLine("resuming 4");
            wh.Set();

        }

        static void fun1()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("First fun :" + i);
            }
        }

        static void fun2()
        {
            for (int i = 101; i < 1100; i++)
            {
                Console.WriteLine("Second fun :" + i);
            }
        }
    }
}
