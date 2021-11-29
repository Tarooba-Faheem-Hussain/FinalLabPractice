using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class Employee : iEmployee
    {
        public string firstname
        {
            get => default;
            set
            {
            }
        }

        public string lastname
        {
            get => default;
            set
            {
            }
        }

        public char gender
        {
            get => default;
            set
            {
            }
        }

        private double calculatePay()
        {
            throw new NotImplementedException();
        }

        public void employee()
        {
            throw new System.NotImplementedException();
        }

        public void displayEmployee()
        {
            throw new System.NotImplementedException();
        }

        double iEmployee.calculatePay()
        {
            throw new NotImplementedException();
        }
    }
}