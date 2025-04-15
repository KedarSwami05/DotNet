namespace Static
{
    internal class Program
    {
        static void Main()
        {
            Class1 o=new Class1(); //this is for normal
            o.i=1; //here write console.writeline to display 
            
            Class1.si=12345;  // this is the way to print the static value variable
            Console.WriteLine(Class1.si);

            //way to call public variable or function
            Class1 o2 = new Class1();
            o2.Display();

            //way to call static variable or function
            Class1.sDisplay();

            Class1.sProp2="";
        }
    }

    public class Class1
    {
        public int i;

        //static variable - name:single copy
        public static int si;


        public void Display()
        {
            Console.WriteLine("Non-Static Display");

            //here you can call both static and non static variable
            Console.WriteLine(i); //non static
            Console.WriteLine(si); //static
        }

        public static void sDisplay()
        {
            Console.WriteLine("Static Display");

            //public variables can not be displayed in static 

           // Console.WriteLine(i); //error

            Console.WriteLine(si);
        }

        private string prop1;
        public string Prop1
        {

            set
            {
                if (value != "")
                    prop1 = value;
                else
                    Console.WriteLine("Invalid name");
            }

            get
            {
                return prop1;
            }
        }

        private static string sprop2;

        public static string sProp2
        {

            set
            {
                if (value != "")
                    sprop2 = value;
                else
                    Console.WriteLine("Static name");
            }

            get
            {
                return sprop2;
            }
        }


        //static constructor
        static Class1() //it is implicitly private
        {
            Console.WriteLine("static constructor");
            si = 333;
            sProp2 = "hello baby";
        }
    }
}