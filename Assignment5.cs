namespace Assignment5
{
    internal class Program
    {

        

        static void Main()
        {
            int[][] Mark = new int[3][];
            int i;
            int j;


            Mark[0] = new int[3];

            Mark[1] = new int[5];

            Mark[2] = new int[7];
           

            for (i = 0; i < Mark.Length; i++)
            {
                Console.WriteLine($"Enter the marks {i + 1}:");


                for (j = 0; j < Mark[i].Length; j++)
                {
                    Console.WriteLine($"Enter the marks of Sudent{j + 1}:");
                    Mark[i][j] = Convert.ToInt32(Console.ReadLine());
                }


            }
            Console.WriteLine();
            for (i = 0; i < Mark.Length; i++)
                for (j = 0; j < Mark[i].Length; j++)
                    Console.WriteLine($"Mark of students in [{i},{j}]:{Mark[i][j]}");

            Console.WriteLine();

            Console.ReadLine();



        }
    }
}