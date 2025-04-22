using System.Globalization;
using System.Reflection.Metadata;

namespace GenericCollections
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);

            List<string> list2 = new List<string>();
            list2.Add("a");
            list2.Add("b");
            list2.Add("c");

            foreach (int item in list)
            {
                Console.WriteLine(item);
            }
            foreach (string item2 in list2)
            {
                Console.WriteLine(item2);
            }
        }
        

        static void Main2(string[] args)
        {
            List<Employee> lstEmps = new List<Employee>();
            Employee o1 = new Employee();
            Employee o2 = new Employee();
            Employee o3 = new Employee();
           

            o1.EmpNo = 1;
            o1.Name = "Kedar";
            o2.EmpNo = 2;
            o2.Name = "Krish";
            o3.EmpNo = 3;
            o3.Name = "Patil";

            lstEmps.Add(o1);
            lstEmps.Add(o2);
            lstEmps.Add(o3);
            //another way of adding the object - Object Initialization method
            lstEmps.Add(new Employee { EmpNo = 4, Name = "Tanmay" });
            foreach (Employee item in lstEmps)
            {
                Console.WriteLine(item.EmpNo);
                Console.WriteLine(item.Name);
            }
        }

        public class Employee
        {
            public int EmpNo { get; set; }
            public string Name { get; set; }
        }

        static void Main()
        {
            SortedList<int, string> sl1 = new SortedList<int, string>();
            sl1.Add(1, "Kedar");
            sl1.Add(2, "Patil");
            sl1[3] = "Krish";

            foreach (KeyValuePair<int, string> item in sl1)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }
        }
    }
}
