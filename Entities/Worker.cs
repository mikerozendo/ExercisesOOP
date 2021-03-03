using System.Collections.Generic;
using System;

namespace Exercicios.Entities
{
    class Worker
    {
        public string Name { get; private set; }
        public double BaseSalary { get; private set; }
        public WorkerLevel WorkerLevel { get; private set; }
        public Department Department { get; private set; }
        public List<HourContract> Contract { get; private set; } = new List<HourContract>();


        public Worker() { }

        public Worker(Department department, string name, WorkerLevel workerLevel, double salary)
        {
            Name = name;
            BaseSalary = salary;
            WorkerLevel = workerLevel;
            Department = department;
        }
        public void AddContract(HourContract contract)
        {
            Contract.Add(contract);
        }
        public void RemoveContract(HourContract contract)
        {
            Contract.Remove(contract);
        }
        public double Income(DateTime searchContract)
        {
            double sum = BaseSalary;
            foreach (HourContract contract in Contract)
            {
                if (contract.Date.Year == searchContract.Year &&
                    contract.Date.Month == searchContract.Month)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }
    }
}
