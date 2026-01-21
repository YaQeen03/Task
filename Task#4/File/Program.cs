using System.Diagnostics.Metrics;
using System;
using System.IO;


namespace Task_4

{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "Employees.txt";
            string[] lines = File.ReadAllLines(str);

            foreach (string s in lines)
            {
                string[] colums = s.Split('\\');
                string name = colums[0];
                string salary = colums[1];
                string department = colums[2];

                int salaryI = int.Parse(salary);

                Console.WriteLine($"Name: {name}");
                Console.WriteLine($"Salary: {salaryI}");
                Console.WriteLine($"Department: {department}");
                Console.WriteLine("------------------------------");

                string outputPath = "results.txt";
                File.WriteAllText(outputPath, "\n");

                foreach (string o in lines)
                {
                    string[] Colums = o.Split('\\');
                    string Name = Colums[0];
                    string Salary = Colums[1];
                    string Department = Colums[2];

                    int SalaryI = int.Parse(Salary);

                    string resultLine = $"{Name} works in {Department} and earns {SalaryI}";
                    File.AppendAllText(outputPath, resultLine + "\n");
                }
            }
        }
    }
}