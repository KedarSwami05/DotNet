using System.Collections;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList obj = new ArrayList();
            obj.Add("hello");
            obj.Add(10);
            obj.Add(true);
            obj.Add(1.234);
            obj.Insert(0, "new");
            ArrayList obj2 = new ArrayList();
            obj2.Add("obj2 item1");
            obj2.Add("obj2 item2");

            //obj.AddRange(obj2);
            //obj.InsertRange(0,obj2);

            //obj.Remove("hello");
            //obj.RemoveAt(0);
            obj.RemoveRange(0, 2);
            foreach (object item in obj)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(obj.Count);

            obj2 = (ArrayList)obj.Clone();

            bool isPresent = obj.Contains("hello");
            object[] arr = new object[obj.Count];
            obj.CopyTo(arr);

            obj2 = obj.GetRange(0, 2);
            obj.SetRange(0, obj2);
            object[] arr2 = obj.ToArray()!;

        }
    }
}