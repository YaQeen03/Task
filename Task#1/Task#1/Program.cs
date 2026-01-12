using System;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Enter a string: ");
            string text = Console.ReadLine();
            Console.WriteLine("You entered: " + text);

            double price = 15.75;
            string name = "Yaqeen";
            char grade = 'A';
            bool isStudent = true;
            int age = 22;
            const double PI = 5.14;

            Console.WriteLine(price);
            Console.WriteLine(name);
            Console.WriteLine(grade);
            Console.WriteLine(isStudent);
            Console.WriteLine(age);
            Console.WriteLine(PI);

            string[] cars = { "BMW", "Toyota", "Honda", "Mercedes" };
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }
            Console.WriteLine(cars.Length);

            Console.Write("Input your first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Input your last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Input your year of birth: ");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine(firstName + " " + lastName + " " + year);

            int[] arr = new int[10];
            Console.WriteLine("Input 10 elements in the array:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("element - " + i + " : ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Elements in array are: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
