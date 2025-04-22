namespace Employee
{
    internal class Program
    {
        static void Main()
        {
            Name n1 = new Name();
            n1.Nprop = "Kedar";
            Console.WriteLine(n1.Nprop);

            EmpNo e1 = new EmpNo();
            e1.Eprop = 101;
            Console.WriteLine(e1.Eprop);

            Basic b1 = new Basic();
            b1.Bprop = 75000;
            Console.WriteLine(b1.Bprop);

            DeptNo d1= new DeptNo();
            d1.Dprop = 7;
            Console.WriteLine(d1.Dprop);
        }
    }



    public class Name
    {
        private string nprop;
        public string Nprop { 
         
            set
            {
                if (value !="")
                    nprop = value;
                else
                    Console.WriteLine("Invalid name");
            }

            get
            {
                return nprop;
            }
        }
    }

    public class EmpNo
    {
        private int eprop;

        public int Eprop
        {

            set
            {
                if (value > 0)
                    eprop = value;
                else
                    Console.WriteLine("Wrong id type");
            }
            get
            {
                return eprop;
            }
        }
    }

    public class Basic
    {
        private decimal bprop;

        public decimal Bprop
        {
            set
            {
                if (value >= 10000 && value <= 80000)
                    bprop = value;
                else
                    Console.WriteLine("incorrect info");
            }

            get
            {
                return bprop;
            }
        }
    }

    public class DeptNo
    {
        private short dprop;

        public short Dprop
        {
            set
            {
                if (value > 0)
                    dprop = value;
                else
                    Console.WriteLine("Wrong Dept num");
            }
            get
            {
                return dprop;
            }
        }
    }
}