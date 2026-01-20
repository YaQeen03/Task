namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int evenCount = 0;
            int oddCount = 0;

            for (int i = 1; i <= 10; i++)
            {
                Console.Write("Enter number " + i + ": ");
                int num = int.Parse(Console.ReadLine());

                if (num < 0)
                {
                    continue;
                }
                if (num == 0)
                {
                    break;
                }

                if (num % 2 == 0)
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;
                }
            }

            Console.WriteLine("Even numbers count: " + evenCount);
            Console.WriteLine("Odd numbers count: " + oddCount);


            //============================================================================
            int grade;

            while (true)
            {
                Console.Write("Enter the student's grade (0-100): ");
                grade = int.Parse(Console.ReadLine());

                if (grade >= 0 && grade <= 100)
                    break;
                else
                    Console.WriteLine("Invalid grade! Please enter a number between 0 and 100.");
            }

            if (grade >= 90)
            {
                Console.WriteLine("A");
            }
            else if (grade >= 80)
            {
                Console.WriteLine("B");
            }
            else if (grade >= 70)
            {
                Console.WriteLine("C");
            }
            else if (grade >= 60)
            {
                Console.WriteLine("D");
            }
            else
            {

                Console.WriteLine("F");

                //===========================================================================================

                while (true)
                {
                    Console.Write("Choose an operation (+, -, *, /): ");
                    string operation = Console.ReadLine();

                    Console.Write("Enter the first num: ");
                    double num1 = double.Parse(Console.ReadLine());

                    Console.Write("Enter the second num: ");
                    double num2 = double.Parse(Console.ReadLine());

                    switch (operation)
                    {
                        case "+":
                            Console.WriteLine("Result: " + (num1 + num2));
                            break;
                        case "-":
                            Console.WriteLine("Result: " + (num1 - num2));
                            break;
                        case "*":
                            Console.WriteLine("Result: " + (num1 * num2));
                            break;
                        case "/":
                            if (num2 != 0)
                            {
                                Console.WriteLine("Result: " + (num1 / num2));
                            }
                            else
                                Console.WriteLine("Cannot divide by zero!");
                            break;
                        default:
                            Console.WriteLine("Invalid operation!");
                            break;
                    }

                    Console.Write("Do you want to continue? (y/n): ");
                    string choice = Console.ReadLine().ToLower();

                    if (choice == "n")
                    {
                        break;
                    }
                }
            }

        }
    }
}

    
    

