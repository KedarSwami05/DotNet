using System;

namespace AnonymousAndLamda
{
   
    internal class Program
    {
        static void Main1()
        {
            Func<string> o1 = delegate()
            {
                return DateTime.Now.ToLongTimeString();
            };
            Console.WriteLine(o1());

            Func<int, int> o2 = delegate (int a)
            {
            return a * 2;
            };
            Console.WriteLine(o2(5));

            Func<int, bool> o3 = delegate (int a)
            {
                if (a % 2 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            };
            Console.WriteLine("even or odd :" + o3(7));

            Func<int, int, int> o4 = delegate (int a, int b)
            {
                return a + b;
            };
            Console.WriteLine(o4(25,30));
        }

        static void Main()
        {
            //normal delegate method
            Func<int,int> o1 = GetDouble;
            Console.WriteLine(o1(10));


            //anonymous delegate method
            Func<int, int> o2 = delegate(int a)
            {
                return a * 2;
            };
            Console.WriteLine(o2(50));


            //lambda method
            Func<int, int> o3 = (a) => a * 2;
            
            Console.WriteLine(o3(75));


            Func<int, int, int> o4 =(a,b) => a + b;
            Console.WriteLine(o4(10, 20));


            Func<int, bool> o5 = (a) =>
            {
                if (a % 2 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            };
            Console.WriteLine(o5(5));

            //another easy way to write conditions in lambda

            Func<int, bool> o6 = (a) => a % 2 == 0;

            Console.WriteLine("easy way to condition :" +o6(15));

            Func<Employee, bool> o7 =obj=> obj.Basic >10000 ;
            Console.WriteLine("basic is greater or not :" + o7(new Employee { Id = 1, Basic = 12000 }));

            Predicate<Employee> o8 = obj => obj.Basic > 10000;
            Console.WriteLine("basic is greater or not :" + o8(new Employee { Id = 1, Basic = 8000 }));
        }


        //below code are just for referance
        static int GetDouble(int a)
        {
            return a * 2;
        }

        static int Add(int a, int b)
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
            if (obj.Basic > 10000)
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
