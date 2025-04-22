namespace Function
{
    public class Program
    {
        static void Main()
        {
            Class2 o = new Class2();
            o.Display();
            o.Display("Hey hey ");
            //Console.WriteLine( o.add());
            Console.WriteLine(o.add(20,40));
            Console.WriteLine(o.add(20, 40,30));

            int ans = o.add(44, 70);
            Console.WriteLine(ans);

            //passing value using name of parameter
            Console.WriteLine(o.add(z:50,x:25));
            Console.WriteLine(o.add(125, z:100));

        }
    }

    public class Class2
    {
        public void Display()
        {
            Console.WriteLine("Kedar");
        }

        public void Display(string s)
        {
            Console.WriteLine(s);
        }

        //public int add()
        //{ 
        //    return 10 + 20;
        //}

        //public int add(int x,int y)
        //{
        //    return x + y;
        //}

        public int add(int x=0, int y=0, int z=0)
        {
            return x+ y + z;
        }
    }
}