namespace LangFeatures
{
    internal class Program
    {
        static void Main1()
        {
            int i = 100;
            var j = 200; //implicit variable
                         //used only for local variable
                         //cant be used for class level vars, fun params and return type

            j = 200;
            //j="aa"; //error

            var k = "aaaa";
            //k=1234; //error

            Console.WriteLine(j);
            Console.WriteLine(j.GetType());
        }
    }
}


namespace AnonymousType
{
    internal class Program
    {
        static void main()
        {
            var obj = new { a = 1, b = "abc", c = true };
            var obj2 = new { a = 2, b = "abcd", c = false, d = 1 };

            Console.WriteLine(obj.a);
            Console.WriteLine(obj.b);
            Console.WriteLine(obj.c);
            //Console.WriteLine(obj.d);

            Console.WriteLine(obj.GetType());
            Console.WriteLine(obj2.GetType());
        }
    }
}
