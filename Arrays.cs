
namespace Arrays
{
    internal class Program
    {
        static void Main0()
        {
            int[] arr = new int[5];
            for (int i = 0; i < arr.Length; i++)
            {
                //Console.Write("enter value for arr[" + i + "]:"); //string concatenation
                //Console.Write("enter value for arr[{0}]:", i); //placeholder
                Console.Write($"enter value for arr[{i}]:"); //string interpolation
                //arr[i] = int.Parse(Console.ReadLine()!);
                //arr[i] = int.Parse(Console.ReadLine());
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"value for arr[{i}] is {arr[i]}"); //string interpolation
            }
            Console.WriteLine();
            foreach (int item in arr)
                Console.WriteLine(item);
        }
        static void Main1()
        {
            int[] arr = new int[5] { 10, 20, 30, 40, 50 };
            //int[] arr = { 10, 20, 30, 40, 50, 60};
            // Array.Clear(arr);
            //int pos = Array.IndexOf(arr, 20);
            //int pos = Array.LastIndexOf(arr, 20);
            int pos = Array.BinarySearch(arr, 20);
            if (pos < 0)
                //if (pos == -1)
                Console.WriteLine("not found");
            else
                Console.WriteLine(pos);
            //Array.Copy(arr, arr2, arr.Length);
            Array.Reverse(arr);
            Array.Sort(arr);
        }
        static void Main2()
        {
            //double dim array
            int[,] arr = new int[3, 5];

            //int[,,] arr2 = new int[2,3, 5]; //3 dim array
            Console.WriteLine(arr.Rank); //no of dimensions
            Console.WriteLine(arr.Length); //no of elements
            Console.WriteLine(arr.GetLength(0)); //length of 1st dimension
            Console.WriteLine(arr.GetLength(1)); //length of 2nd dimension
            Console.WriteLine(arr.GetUpperBound(0)); //upper bound of 1st dimension
            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"enter value for arr[{i},{j}]:"); //string interpolation
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            Console.WriteLine();
            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(1); j++)
                    Console.WriteLine($" value for arr[{i},{j}] : {arr[i, j]}"); //string interpolation
        }

        static void Main3()
        {
            //string[] arr = new string[5];
            Employee[] arr = new Employee[5];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new Employee();
                arr[i].EmpNo = Convert.ToInt32(Console.ReadLine());
                arr[i].Name = Console.ReadLine();
            }
            foreach (Employee item in arr)
            {
                Console.WriteLine(item.EmpNo);
                Console.WriteLine(item.Name);
            }
        }
        static void Main()
        {
            //jagged
            int[][] arr = new int[4][];

            //for (int i = 0; i < arr.Length; i++)
            //arr[i] = new int[X]

            arr[0] = new int[3]; // arr[0][0] arr[0][1] arr[0][2]
            arr[1] = new int[4]; // arr[1][0] arr[1][1] arr[1][2] arr[1][3]
            arr[2] = new int[2];//  arr[2][0] - arr [2][1]
            arr[3] = new int[3];//  arr[3][0] arr[3][1] arr[3][2]

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write($"enter value for batch {i}, student {j} - subscript [{i}][{j}] : ");
                    arr[i][j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.ReadLine();
                Console.WriteLine();
            }


            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.WriteLine("value for subscript {0},{1} is {2}  ", i, j, arr[i][j]);

                }
            }
            Console.ReadLine();
        }
    }

    public class Employee
    {
        public int EmpNo { get; set; }
        public string Name { get; set; }

    }
}