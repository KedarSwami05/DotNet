namespace DeligatesEx
{
    //step 1: Create deligates class having the same signature as the fun to call

    public delegate void Del1(); //del1 is class
    public delegate int Del2(int x, int y);

    internal class Program
    {
        static void Main1(string[] args)
        {
            //setp 2: declare a reference of the deligate class.
            //Create an object of the deligate class and make the delegate referance
            //refer to the delegate object

            Del1 objDel = new Del1(Display);

            //step 3 : call the fun via the delegate referance

            objDel();
        }

        static void Main2(string[] args)
        {
            //another way to write delegate
            Del1 objDel = Display;
            objDel();

            objDel = Show;
            objDel();
        }

        static void Main3()
        {
            Del1? objDel = Display; // to remove warning use ?
            objDel();


            Console.WriteLine();
            objDel += Show;
            objDel();

            Console.WriteLine();
            objDel += Display;  //to add one more fun
            objDel();

            Console.WriteLine();
            objDel -= Display;     //to remove the last display fun
            objDel!();  // to remove waring use !

            Console.WriteLine();
            objDel -= Display;
            objDel!();

            
        }

      
        static void Main4()
        {

            Del2 objDel2 = Add;
            objDel2 += Subtract;
            Console.WriteLine(objDel2(10,5));

          
            //Console.WriteLine(objDel2(25, 5));

        }

        static void Main()
        {
            Del1 objDel = (Del1)Delegate.Combine(new Del1(Display), new Del1(Show), new Del1(Display));
            objDel();

            Console.WriteLine();

           //objDel = (Del1)Delegate.Remove(objDel ,new Del1(Display));
            objDel = (Del1)Delegate.RemoveAll(objDel, new Del1(Display));
            objDel();
        }
        static void Display()
        {
            Console.WriteLine("Display");
        }
        static void Show()
        {
            Console.WriteLine("Show");
        }

        static int Add(int x,int y)
        {
            return x + y;
            
        }

        static int Subtract(int x, int y)
        {
            return x - y;

        }
    }
}

