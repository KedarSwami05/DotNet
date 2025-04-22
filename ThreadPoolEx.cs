namespace ThreadPoolEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            ThreadPool.QueueUserWorkItem(new WaitCallback(poolFun1), "Passed Value :");
            ThreadPool.QueueUserWorkItem(poolFun2, "Passed Value 2 :");

            //ThreadPool.QueueUserWorkItem(new WaitCallback(poolFun1));
            //ThreadPool.QueueUserWorkItem(poolFun2);

            int workerthread, iothreads;

            ThreadPool.GetAvailableThreads(out workerthread, out iothreads);

            Console.WriteLine(workerthread);
            Console.WriteLine(iothreads);

            Console.ReadLine();
        }

        static void poolFun1(object obj)
        {
            for (int i = 101; i < 110; i++)
            {
                Console.WriteLine("First fun :" + i.ToString()  + obj.ToString());

            }
        }
        static void poolFun2(object obj)
        {
            for (int i = 1; i < 100; i++)
            {
                Console.WriteLine("2nd fun :" + i.ToString() +obj.ToString());
            }
        }
    }
}
