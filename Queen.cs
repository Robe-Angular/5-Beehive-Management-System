﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Beehive_Management_System
{
    class Queen:Bee
    {
        public Queen(Worker[] workers):base(275)
        {
            this.workers = workers;
        }

        private Worker[] workers;
        private int shiftNumber = 0;
        public bool AssignWork(string job, int numberOfshifts)
        {
            for(int i = 0; i < workers.Length; i++)
            {
                if (workers[i].DoThisJob(job, numberOfshifts))
                    return true;
                
            }                   
                    
            return false;
        }

        public string WorkTheNextShift()
        {
            double totalConsumption = 0;
            for (int i = 0; i < workers.Length; i++)
                totalConsumption += workers[i].GetHoneyConsumption();
            totalConsumption += GetHoneyConsumption();
            shiftNumber++;
            string report = $"Report for shift #{shiftNumber} \r\n";
            for(int i = 0; i < workers.Length; i++)
            {
                if (workers[i].WorkOneShift())
                    report += $"Worker #{i + 1} finished the job\r\n";
                if (String.IsNullOrEmpty(workers[i].CurrentJob))
                    report += $"Worker #{i + 1} is not working\r\n";
                else
                    if (workers[i].ShiftsLeft > 0)
                    report += $"Worker #{i + 1} is doing '{workers[i].CurrentJob}' " +
                        $"for {workers[i].ShiftsLeft} more shifts\r\n";
                else
                    report += $"Worker #{i + 1} will be done with '{workers[i].CurrentJob}' " +
                        $"after this shift\r\n";
            }
            report += $"Total honey consumption: {totalConsumption} units";
            return report;
        }

        public override double GetHoneyConsumption()
        {
            double consumption = 0;
            double largestDoubleConsumption = 0;
            int workersDoingJobs = 0;
            for(int i=0; i < workers.Length; i++)
            {
                if (workers[i].GetHoneyConsumption() > largestDoubleConsumption)
                    largestDoubleConsumption = workers[i].GetHoneyConsumption();
                if (workers[i].ShiftsLeft > 0)
                    workersDoingJobs++;
            }
            consumption += largestDoubleConsumption;
            consumption = workersDoingJobs >= 3 ? 30 : 20;
            return consumption;
        }
    }
}
