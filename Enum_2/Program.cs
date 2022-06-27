using System;
using System.Globalization;
using System.Collections.Generic;
using Enum_2.Entities;
using Enum_2.Entities.Enums;

namespace Enum_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            string dpName = Console.ReadLine();
            Console.WriteLine("Enter worker data ↓");
            Console.Write("Name: ");
            string nameWorker = Console.ReadLine();
            Console.Write("Level (Junior, MidLevel, Senior): ");
            WorkerLevel levelWorker = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base Salary: ");
            double salaryWorker = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department dp = new Department(dpName);
            Worker worker = new Worker(nameWorker,levelWorker,salaryWorker,dp);

            Console.Write("How many contracts will be assigned to this worker? ");
            int x = int.Parse(Console.ReadLine());
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine("Enter #" + i + " contract data ↓");
                Console.Write("Date (dd/mm/yyyy): ");
                DateTime dateTime = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePHour = double.Parse(Console.ReadLine());
                Console.Write("Duration (hours): ");
                int totalHours = int.Parse(Console.ReadLine());

                HourContract contracts = new HourContract(dateTime, valuePHour, totalHours);
                worker.AddContract(contracts);
            }
            Console.Write("Enter the month and year (mm/yyyy) to calculate the income: ");
            string pickDate = Console.ReadLine();
            int month = int.Parse(pickDate.Substring(0, 2)); // pegas os dois primeiros valores da string
            int year = int.Parse(pickDate.Substring(3)); // pega a partir da terceira letra da string
            Console.WriteLine("Name: " + worker.Name + "\nDepartment: " + worker.Department.Name + "\nIncome for " + pickDate + ": " + worker.Income(year,month).ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}