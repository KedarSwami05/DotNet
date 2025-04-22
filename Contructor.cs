namespace Constructor
{

    internal class program
    {
        static void Main()
        {
            Employee e1 = new Employee();
            Console.WriteLine(e1.EmpNo);
            Console.WriteLine(e1.EmpName);
            Console.WriteLine(e1.Basic);

            Employee e2 = new Employee(102,"Chota Bhim",25000);
            Console.WriteLine(e2.EmpNo);
            Console.WriteLine(e2.EmpName);
            Console.WriteLine(e2.Basic);

            Employee e3 = new Employee(103, "BatMan");
            Console.WriteLine(e3.EmpNo);
            Console.WriteLine(e3.EmpName);
            Console.WriteLine(e3.Basic);

        }
    }
    public class Employee
    {
        public int EmpNo;
        public string EmpName;
        public int Basic;

        //public Employee()
        //{
        //    Console.WriteLine("no para contructor");
        //    EmpNo = 1;
        //    EmpName = "Shaktiman";
        //    Basic = 20000;
        //}

        //public Employee(int EmpNo, string EmpName, int Basic)
        //{
        //    Console.WriteLine("This is para meterised contructor");
        //    this.EmpNo = EmpNo; //here this. is a referance 
        //    this.EmpName = EmpName;
        //    this.Basic = Basic;
        //}

        public Employee(int EmpNo=101 ,string EmpName ="HitMan",int Basic=30000)
        {
            this.EmpNo = EmpNo;
            this.EmpName = EmpName;
            this.Basic = Basic;
        }
    }
}