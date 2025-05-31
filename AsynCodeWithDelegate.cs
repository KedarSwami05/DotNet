using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


//call a fun asynchrously
//no para and void return type

namespace AsynCodeWithDelegate1
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("Before ");
            Action oDel = Display;
            //oDel(); //sync call
            oDel.BeginInvoke(null, null); //async call fun on separate thread
            Console.WriteLine("After ");
            Console.ReadLine();
        }

        static void Display()
        {
            Thread.Sleep(5000);
            Console.WriteLine("Display");
        }
    }
}


namespace AsynCodeWithDelegate2
{
    internal class Program
    {
        static void Main2(string[] args)
        {
            Console.WriteLine("Before ");
            Action<string> oDel = Display;
            //oDel(); //sync call
            oDel.BeginInvoke("Passed value",null, null); //async call fun on separate thread
            Console.WriteLine("After ");
            Console.ReadLine();
        }

        static void Display(string s)
        {
            Thread.Sleep(5000);
            Console.WriteLine("Display" +s);
        }
    }
}

namespace AsynCodeWithDelegate3
{
    internal class Program
    {
        static void Main3(string[] args)
        {
            Console.WriteLine("Before ");
            Func<string,string> oDel = Display;
            //oDel(); //sync call
            oDel.BeginInvoke("Passed value", new AsyncCallback(CallbackFun), null); //async call fun on separate thread
            Console.WriteLine("After ");
            Console.ReadLine();
        }

        static void CallbackFun(IAsyncResult ar)
        {
            Console.WriteLine("callback fun called");
        }
        static string Display(string s)
        {
            Thread.Sleep(5000);
            Console.WriteLine("Display" + s);
            return s.ToUpper();
        }
    }
}


namespace AsynCodeWithDelegate4
{
    internal class Program
    {
        static void Main4(string[] args)
        {
            Console.WriteLine("Before ");
            Func<string, string> oDel = Display;
            //oDel(); //sync call
            IAsyncResult ar1 = oDel.BeginInvoke("Passed value", delegate(IAsyncResult ar)
        {
                Console.WriteLine("callback fun called");
                string retval = oDel.EndInvoke(ar);
                Console.WriteLine(retval);
            }, null); //async call fun on separate thread
            Console.WriteLine("After ");
            Console.ReadLine();
        }

        //static void CallbackFun(IAsyncResult ar)
        //{
        //    Console.WriteLine("callback fun called");
        //    string retval = oDel.EndInvoke(ar); 
        //    Console.WriteLine(retval);
        //}
        static string Display(string s)
        {
            Thread.Sleep(5000);
            Console.WriteLine("Display" + s);
            return s.ToUpper();
        }
    }
}

namespace AsynCodeWithDelegate5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Before ");
            Func<string, string> oDel = Display;
            //oDel(); //sync call
            //oDel.BeginInvoke("Passed value", new AsyncCallback(CallbackFun), "extra data");
            //oDel.BeginInvoke("Passed value", new AsyncCallback(CallbackFun), 123);//async call fun on separate thread
            oDel.BeginInvoke("Passed value", new AsyncCallback(CallbackFun), oDel);
            Console.WriteLine("After ");
            Console.ReadLine();
        }

        static void CallbackFun(IAsyncResult ar)
        {
            //string last_para = ar.AsyncState.ToString();
            //Console.WriteLine(last_para);

            //int last_para = (int)ar.AsyncState;
            //Console.WriteLine(last_para);

            Func<string, string> oDel =(Func<string, string>) ar.AsyncState;

            Console.WriteLine("callback fun called");
            string retval = oDel.EndInvoke(ar);
            Console.WriteLine(retval);

        }
        static string Display(string s)
        {
            Thread.Sleep(5000);
            Console.WriteLine("Display" + s);
            return s.ToUpper();
        }
    }
}
