namespace Function
{
    internal class Program
    {
        static void Main1()
        {
            Class1 o = new Class1();
            //o.i = 12345;
            o.Seti(10);
            Console.WriteLine(o.Geti());


        }
        static void Main2()
        {
            Class2 o = new Class2();

            o.Prop1 = 10000;   //set to give value
            Console.WriteLine(o.Prop1); //get the value 
        }

        static void Main()
        {
            Class3 o = new Class3();

            o.Prop2 = 10000;   //set to give value
            Console.WriteLine(o.Prop2); //get the value 


            o.Prop3 = "a";
            Console.WriteLine(o.Prop3);

            o.Prop4 = "b";
            Console.WriteLine(o.Prop4);
        }


    }

    public class Class1
    {
        private int i;

        public void Seti(int value)  //int value : to get value from user
        {
            if (value <= 100)
                i = value; // to store value in i
            else
                Console.WriteLine("invalid value");
        }

        public int Geti()
        {
            return i;
        }
    }

    public class Class2
    {
        private int prop1;

        public int Prop1
        {
            set
            {
                if (value <= 100)
                    prop1 = value;
                else
                    Console.WriteLine("Invalidddddddeeeeeeee");
            }
            get
            {
                return prop1;
            }
        }
    }

    public class Class3
    {
        private int prop2;

        public int Prop2
        {
            set
            {
                prop2 = value;
            }
            get { 
                return prop2; 
            }
        }

        //to do - create a read only property (only get)
        public string Prop3;


        //when there are no validations
        //auto/automatic property
        //compiler generates code for get/set
        //compiler generates private variable
        public string Prop4 { get; set; }
    }

   
}