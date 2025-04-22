namespace AnonymousMethod
{
    public delegate void Del1();
    internal class Program
    {
        static void Main(string[] args)
        {
            //Display();
            //Del1 odel = Display;
            //odel();

            int i= 100; //local variable

            Del1 odel2 = delegate ()
        {
            Console.WriteLine(++i); // anonymous methods can access the local varible
                                    // it can also access "Anonymous Type" (Type means Class in dontnet) 
            Console.WriteLine("Anno method");
        };
            odel2 ();
        }
    

    static void Display()
        {
            Console.WriteLine("Display");
        }
    }
}
