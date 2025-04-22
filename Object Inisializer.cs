namespace ObjectIni
{
    internal class program
    {
        static void Main()
        {
            Employee e1 = new Employee();
            Console.WriteLine(e1.EmpNo);
            Console.WriteLine(e1.EmpName);
            Console.WriteLine(e1.Basic);

            //object initializer : to be used only when there is no parameterised constructor
            //it allow you to write code shorter+
            Employee e2 = new Employee() { EmpNo = 101, EmpName = "Wonder Woman", Basic = 75000 };
            Employee e3 = new Employee() { EmpNo = 102, EmpName = "ironman", Basic = 5000 };// another way to write it

        }

        public class Employee
        {
            public int EmpNo { get; set; }
            public string EmpName { get; set; }
            public int Basic { get; set; }

        }
    }
}