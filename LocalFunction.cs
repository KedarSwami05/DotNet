namespace LocalFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            class1 o = new class1();
            o.Display();
        }
    }

    public class class1
    {
        public void Display()
        {
            int i = 100;// local variable
            //local fun(fun within another fun
            //implicitly private
            //only available to the outer fun
            //overloading local fun is not allowed


            void DoSomething()
            {
                i++;
                Console.WriteLine(i);
                //local fun can access variable declared in the outer fun
            }

            static void StaticSomething()
            {
               // i++;    show error
                //Console.WriteLine(i);
                //Static local fun CANNOT access variable declared in the outer fun
            }

            StaticSomething();
            DoSomething();
            Console.WriteLine(i);
        }
    }
}
