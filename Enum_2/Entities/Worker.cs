﻿using System;
using Enum_2.Entities.Enums;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_2.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        // Como podemos ter mais de um contract por woker, temos que usar List
        public List<HourContract> Contracts { get; private set; } = new List<HourContract>();
        

        public Worker()
        {

        }
        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }
        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }
        public double Income(int year, int month)
        {
            double sum = BaseSalary;
            foreach (HourContract contract in Contracts)
            {
                if(contract.Date.Year == year && contract.Date.Month == month)
                {
                    //Console.WriteLine("Entrou!");
                    sum += contract.TotalValue();
                }
                else
                {
                    //Console.WriteLine("Não Entrou!");
                }
            }
            return sum;
        }
    }
}
