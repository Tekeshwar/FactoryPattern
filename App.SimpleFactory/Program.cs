using App.SimpleFactory.Factory;
using App.SimpleFactory.Manager;
using App.SimpleFactory.Model;
using System;

namespace App.SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Employees employees = new Employees();
            Console.WriteLine("Enter the Employee Name:- ");
            string employeeName = string.Empty;
            employeeName = Console.ReadLine();

            Console.WriteLine("Employee Type number (1=Permanent, 2= Contractor):- ");
            int employeeTypeID = Convert.ToInt32( Console.ReadLine());

            employees.Name= employeeName;
            employees.EmployeeTypeID = employeeTypeID;

            // ====pass data to factory====
            EmployeeManagerFactory employeeManagerFactory = new EmployeeManagerFactory();
            IEmployeeManager empManager = employeeManagerFactory.GetEmployeeManager(employees.EmployeeTypeID);
            employees.Bonus = empManager.GetBonus();
            employees.HourlyPay = empManager.GetPay();

            //======= add employee db======
            Console.WriteLine("Employee Name:- " + employees.Name);
            Console.WriteLine("Employee Bonus:- "+ employees.HourlyPay);
            Console.WriteLine("Employee Bonus:- "+ employees.Bonus);



        }
    }
}
