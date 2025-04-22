namespace ActionFunPredicate
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            Action o1 = Display;
            o1();

            Action<string> o2 = Display;
            o2("REPLAY");

            Action<string,int> o3 = Display;
            o3("REPLAY",2);
        }

        static void Display()
        {
            Console.WriteLine("Action");
        }

        static void Display(string s)
        {
            Console.WriteLine("Action " +s);
        }

        static void Display(string s,int i)
        {
            Console.WriteLine("Action " + s + i);
        }

        static void Main()
        {
            Func<string> o1 = GetTime;
            Console.WriteLine(o1());

            Func<int, int> o2 = GetDouble; //1st int is for parameter and 2nd int is for return
            Console.WriteLine(o2(10));

            Func<int, int,int> o6 = Add; 
            Console.WriteLine(o6(10,20));

            Func<int, bool> o3 = IsEven;//1st int is for para and bool is for return type
            Console.WriteLine(o3(5));

            Func<Employee ,bool> o4 = IsBasic;
            Console.WriteLine("basic is greater or not :"+o4(new Employee { Id=1,Basic=12000}));

            Predicate<Employee>o5 = IsBasic;
            Console.WriteLine("basic is greater or not :" + o4(new Employee { Id = 1, Basic = 8000 }));
        }


        static string GetTime()
        {
            return DateTime.Now.ToLongTimeString();
        }

        static int GetDouble(int a)
        {
            return a*2;
        }

        static int Add(int a,int b)
        {
            return a + b;
        }

        static bool IsEven(int a)
        {
            if (a % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool IsBasic(Employee obj)
        {
            if (obj.Basic>10000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Basic { get; set; }
    }
}
