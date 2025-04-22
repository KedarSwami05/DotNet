namespace Task1
{
    internal class Program
    {
        static void Main()
        {
            Employee e = new Employee();
            e.Name = "Kedar";
            Console.WriteLine(e.Name);

            //EmpNo e1 = new EmpNo();
            e.EmpNo = 101;
            Console.WriteLine(e.EmpNo);

            //Basic b1 = new Basic();
            e.Basic = 75000;
            Console.WriteLine(e.Basic);

            //DeptNo d1 = new DeptNo();
            e.Dptno = 7;
            Console.WriteLine(e.Dptno);
        }
    }

    public class Employee
    {
        private string name;
        public string Name
        {

            set
            {
                if (value != "")
                    name = value;
                else
                    Console.WriteLine("Invalid name");
            }

            get
            {
                return name;
            }
        }




        private int empNo;

        public int EmpNo
        {

            set
            {
                if (value > 0)
                    empNo = value;
                else
                    Console.WriteLine("Wrong id type");
            }
            get
            {
                return empNo;
            }
        }



        private decimal basic;

        public decimal Basic
        {
            set
            {
                if (value >= 10000 && value <= 80000)
                    basic = value;
                else
                    Console.WriteLine("incorrect info");
            }

            get
            {
                return basic;
            }
        }



        private short dptno;

        public short Dptno
        {
            set
            {
                if (value > 0)
                    dptno = value;
                else
                    Console.WriteLine("Wrong Dept num");
            }
            get
            {
                return dptno;
            }
        }

        public decimal GetNetSalary()
        {
            decimal hra = Basic * (decimal)0.2;
            decimal hra = Basic * 0.2M;
            decimal hra = Basic * Convert.ToDecimal( 0.2);
        }
    }

}