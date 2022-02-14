using System;
using static System.Console;

namespace CalculatePay
{
    class CalculatePay
    {
        static void Main(string[] args)
        {
            Employee firstEmployee = new Employee();
            Write("Please enter the employee's name: ");
            firstEmployee.SetEmployeeName(ReadLine());
            Write("Please enter the employee's weekly sales: ");
            firstEmployee.SetWeeklySalesAmount(double.Parse(ReadLine()));
            firstEmployee.CalculateTakeHomePay();
            WriteLine(firstEmployee.CalculateTakeHomePay());

        }
    }


    class Employee
    {
        private const double federalTax = .18;
        private const double socialSecurity = .06;
        private const double retirementContribution = .10;
        private const double portionOfSales = .07;

        private string employeeName;
        private double weeklySalesAmount;
        private double commission;
        private double federalTaxWitholding;
        private double socialSecurityWitholding;
        private double retirmentContribution;
        private double takeHomePay;

        public Employee()
        {
            employeeName = "John Doe";
            weeklySalesAmount = 0;

        }

        public Employee(string name)
        {
            employeeName = name;
        }

        public Employee(string name, double salesAmount)
        {
            employeeName = name;
            weeklySalesAmount = salesAmount;
        }



        public string GetEmployeeName()
        {
            return employeeName;
        }

        public double WeeklySalesAmount()
        {
            return weeklySalesAmount;
        }

        public void SetEmployeeName(string name)
        {
            employeeName = name;
        }

        public void SetWeeklySalesAmount(double salesAmount)
        {
            weeklySalesAmount = salesAmount;
        }

        public double CalculateCommission()
        {
            commission = weeklySalesAmount * portionOfSales;
            return commission;
        }

        public void CalculateFederalWitholding()
        {
            federalTaxWitholding = commission * federalTax;
        }

        public double GetFederalWitholding()
        {
            return federalTaxWitholding;
        }

        public void CalculateSocialSecurityWitholding()
        {
            socialSecurityWitholding = commission * socialSecurity;
        }

        public double GetSocialSecuritySecurityWitholding()
        {
            return socialSecurityWitholding;
        }

        public void CalculateRetirmentContribution()
        {
            retirmentContribution = commission * retirementContribution;
        }

        public double CalculateTakeHomePay()
        {
            CalculateCommission();
            CalculateFederalWitholding();
            CalculateRetirmentContribution();
            CalculateSocialSecurityWitholding();
            takeHomePay = commission - federalTaxWitholding - socialSecurityWitholding - retirmentContribution;
            return takeHomePay;
        }




    }


}
