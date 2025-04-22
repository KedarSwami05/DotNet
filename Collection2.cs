using System.Collections;

namespace Collections2
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            //Hashtable oDictionary = new Hashtable();
           SortedList oDictionary = new SortedList();

            //1st method to add
            oDictionary.Add(10,"Prithavi");
            oDictionary.Add(20,"Junaid");
            oDictionary.Add(30, "Tejas");
            oDictionary.Add(40, "Krish");

            //2nd  method to add
            oDictionary[50] = "Patil";
            oDictionary[20] = "Tanmay"; // if it is already on key then it will replace the value i.e junaid to tanmay

            //to remove
            oDictionary.Remove(50);

            //contains give true and false value by checking the key is present or not
            Console.WriteLine("Contains :"+ oDictionary.Contains(20)); //20 = Key
            Console.WriteLine("Keys : "+ oDictionary.ContainsKey(60));

            Console.WriteLine("Value :" + oDictionary.ContainsValue("Krish")); //value

            Console.WriteLine("Index :"+ oDictionary.GetByIndex(3));//returns value when index is given , 3 is index

            Console.WriteLine("Returns Key :"+ oDictionary.GetKey(3)); //returns key when index is given

            IList keys = oDictionary.GetKeyList(); //give the list of keys
            IList values = oDictionary.GetValueList(); //give the list of values

            Console.WriteLine("Index of Key :" + oDictionary.IndexOfKey(20));
            Console.WriteLine("Index of Values :" + oDictionary.IndexOfValue("Patil"));

            foreach (DictionaryEntry item in oDictionary)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }
            
            foreach(object o in keys)
            {
                Console.WriteLine("key list :" + o);
                
            }
            foreach (object o2 in values)
            {
                Console.WriteLine("value list :" + o2);

            }

        }

        static void Main()
        {
            //Last In First Out
            //Stack s=new Stack();
            //s.Push(10);
            //s.Push(20);
            //s.Push(30);
            //Console.WriteLine(s.Peek()); //peek return element of last
            //Console.WriteLine(s.Pop()); //return and remove the last elements


            //First In Fist Out
            Queue q = new Queue();
            q.Enqueue(101);
            q.Enqueue(102);
            q.Enqueue(103);
            Console.WriteLine(q.Peek());
            Console.WriteLine(q.Dequeue()); //return and remove first element
        }
    }
}
