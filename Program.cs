using System;
using System.Globalization;
using Exercicios.Entities;
using System.Collections.Generic;

namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the department's name: ");
            string workerDepartment = Console.ReadLine();
            Department worker = new Department(workerDepartment);
            Console.WriteLine("Enter worker data");
            Console.Write("Name: ");
            string workerName = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            string workerLvl = Console.ReadLine();
            Enum.TryParse(workerLvl, out WorkerLevel workerLevel);
            Console.Write("Base Salary: ");
            double workerBaseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Worker workerData = new Worker(worker, workerName, workerLevel, workerBaseSalary);
            Console.WriteLine();

            Console.Write("How  many contracts to this worker? ");
            int control = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= control; i++)
            {
                Console.WriteLine("Enter the #{0} contract data", i);
                Console.Write("Date: ");
                string date = Console.ReadLine();
                DateTime dateContract = DateTime.Parse(date);
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(dateContract, hours, valuePerHour);
                workerData.AddContract(contract);
                Console.WriteLine();
            }

            Console.Write("Enter mounth and year to calculate the income (MM/YYYY): ");

            string dateIncome = Console.ReadLine();
            DateTime searchContract = DateTime.Parse(dateIncome);
            Console.WriteLine("Name: {0}", workerData.Name);
            Console.WriteLine("Department: {0}", workerData.Department.NameDepartment);
            Console.WriteLine("Income for " + searchContract.Month + "/" + searchContract.Year +
                ": " + workerData.Income(searchContract).ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
