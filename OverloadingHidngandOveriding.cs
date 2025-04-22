namespace OverloadingHidngandOveriding
{
    internal class Program
    {
        static void Main1(string[] args)
        {
           DerivedClass o = new DerivedClass();
            o.Display1();  //base
            o.Display1("Hello everyone"); //method

            o.Display2();
            o.Display3();
        }

        static void Main(string[] args)
        {
            BaseClass o; //A
            o = new BaseClass();//B- pointing the object

           //non virtual method depends on how the referance has been declared
            o.Display2();//A - referance

            //virtual method - depends on what object it is pointing
            o.Display3();// B

            
            o = new DerivedClass();
       
            o.Display2();
            o.Display3();

            o = new SubDerivedClass();
            o.Display3();

            o = new SubSubDerivedClass();
            o.Display3();
        }
    }

    public class BaseClass
    {
        public void Display1()
        {
            Console.WriteLine("base display1");
        }
        public void Display2()
        {
            Console.WriteLine("base display2");
        }
        public virtual void Display3() //need to write virtual keyword to use override
        {
            Console.WriteLine("base display3");
        }
    }

    public class DerivedClass : BaseClass
    {
        //overloading of the base class method
        public void Display1(string s)
        {
            Console.WriteLine("Derived display1"+s);
        }

        //Hinding of the base class method
        public new void Display2()  // new keyword is used for hinding the base class and
                                    // while have same  name as base class
        {
            Console.WriteLine("Derived display 2");
        }

        //override of the base class method
        public override  void Display3() //need to write override keyword 
        {
            Console.WriteLine("Derived display3");
        }
    }
    public class SubDerivedClass : DerivedClass
    {
        //overloading of the base class method
        public override sealed void Display3() // sealed is written to stop virtual overriding
        {
            Console.WriteLine("SubDerived display 3");
        }
    }

    public class SubSubDerivedClass : SubDerivedClass
    {
        //overloading of the base class method
        public new void Display3()
        {
            Console.WriteLine("SubSubDerived display 3");
        }
    }
}
