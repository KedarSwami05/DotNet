namespace InhiranceEx
{
    internal class Program
    {
        public void Main()
        {
            BaseClass o = new BaseClass();
        }
    }

    public class BaseClass
    {
        public string A { get; set; }
        public string B { get; set; }
    }

    public class DriveredClass : BaseClass
    {
        public string C { get; set; }
    }
}