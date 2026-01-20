namespace Task_3_Section_1_3__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //===============Section 1: Multidimensional Arrays===========================
            //===============TASK1========================================================
            int[,] array1 = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("Enter value for array[" + i + "," + j + "]: ");
                    array1[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("The 3x3 array is:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                    Console.Write(array1[i, j] + "\t");
                Console.WriteLine();
            }

            //===============TASK2========================================================
            int[,] array2 = {
                { 99, 88, 77, 66 },
                { 0, 1, 2, 3 },
                { 77, 66, 55, 44 },
                { 4, 5, 6, 7 }
            };
            int rows2 = array2.GetLength(0);
            int cols2 = array2.GetLength(1);
            for (int i = 0; i < rows2; i++)
            {
                int rowSum = 0;
                for (int j = 0; j < cols2; j++)
                    rowSum += array2[i, j];
                Console.WriteLine("Sum of row " + i + ": " + rowSum);
            }

            for (int j = 0; j < cols2; j++)
            {
                int colSum = 0;
                for (int i = 0; i < rows2; i++)
                    colSum += array2[i, j];
                Console.WriteLine("Sum of column " + j + ": " + colSum);
            }

            //===============TASK3========================================================
            int[,] array3 = new int[5, 5];
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                    array3[i, j] = rnd.Next(1, 51);

            Console.WriteLine("The 5x5 array:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                    Console.Write(array3[i, j] + "\t");
                Console.WriteLine();
            }

            Console.WriteLine("\nLargest value in each row:");
            for (int i = 0; i < 5; i++)
            {
                int max = array3[i, 0];
                for (int j = 1; j < 5; j++)
                    if (array3[i, j] > max)
                        max = array3[i, j];
                Console.WriteLine("Row " + i + ": " + max);
            }

            Console.WriteLine("\nSmallest value in each column:");
            for (int j = 0; j < 5; j++)
            {
                int min = array3[0, j];
                for (int i = 1; i < 5; i++)
                    if (array3[i, j] < min)
                        min = array3[i, j];
                Console.WriteLine("Column " + j + ": " + min);
            }

            //===============Section 2: Jagged Arrays=======================================
            //===============TASK4========================================================
            int[][] jagged1 = new int[3][];
            jagged1[0] = new int[2];
            jagged1[1] = new int[3];
            jagged1[2] = new int[4];

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < jagged1[i].Length; j++)
                {
                    Console.Write($"Enter value for row {i}, element {j}: ");
                    jagged1[i][j] = int.Parse(Console.ReadLine());
                }

            Console.WriteLine("Jagged Array:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < jagged1[i].Length; j++)
                    Console.Write(jagged1[i][j] + "\t");
                Console.WriteLine();
            }

            //===============TASK5========================================================
            Console.Write("Enter number of rows for jagged array: ");
            int jaggedRows = int.Parse(Console.ReadLine());
            int[][] jagged2 = new int[jaggedRows][];
            for (int i = 0; i < jaggedRows; i++)
            {
                Console.Write($"Enter length of row {i}: ");
                int length = int.Parse(Console.ReadLine());
                jagged2[i] = new int[length];
                for (int j = 0; j < length; j++)
                {
                    Console.Write("Enter value for row " + i + " element " + j + ": ");
                    jagged2[i][j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Jagged Array 2:");
            for (int i = 0; i < jaggedRows; i++)
            {
                for (int j = 0; j < jagged2[i].Length; j++)
                    Console.Write(jagged2[i][j] + "\t");
                Console.WriteLine();
            }

            //===============TASK6========================================================
            int[][] jagged3 = new int[5][];
            for (int i = 0; i < 5; i++)
            {
                jagged3[i] = new int[i + 1];
                for (int j = 0; j < jagged3[i].Length; j++)
                    jagged3[i][j] = rnd.Next(1, 101);
            }

            Console.WriteLine("Jagged Array 3 with random numbers:");
            for (int i = 0; i < 5; i++)
            {
                int sum = 0;
                for (int j = 0; j < jagged3[i].Length; j++)
                {
                    Console.Write(jagged3[i][j] + "\t");
                    sum += jagged3[i][j];
                }
                Console.WriteLine(" Sum: " + sum);
            }

            //===============Section 3: Lists===============================================
            //===============TASK7========================================================
            List<int> list1 = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                list1.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine("List of numbers:");
            foreach (int num in list1)
                Console.WriteLine(num);

            //===============TASK8========================================================
            List<string> names = new List<string>();
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter student name {i + 1}: ");
                names.Add(Console.ReadLine());
            }
            names.Sort();
            Console.WriteLine("Sorted names:");
            foreach (string name in names)
                Console.WriteLine(name);

            //===============TASK9========================================================
            List<int> list2 = new List<int>();
            while (true)
            {
                Console.Write("Enter a number (-1 to stop): ");
                int num = int.Parse(Console.ReadLine());
                if (num == -1)
                    break;
                list2.Add(num);
            }

            Console.WriteLine("Numbers entered:");
            foreach (int num in list2)
                Console.WriteLine(num);

            Console.WriteLine("Average: " + list2.Average());
            Console.WriteLine("Max: " + list2.Max());
            Console.WriteLine("Min: " + list2.Min());

            list2.Sort();
            Console.WriteLine("Sorted numbers:");
            foreach (int num in list2)
                Console.WriteLine(num);
        }
    }
}