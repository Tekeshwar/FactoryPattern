using App.SimpleFactory.Factory.FactoryMethod;
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
            //=== Get user inputs=====
            Console.WriteLine("Enter the Employee Name:- ");
            string employeeName = string.Empty;
            employeeName = Console.ReadLine();

            Console.WriteLine("Employee Type number (1=Permanent, 2= Contractor):- ");
            int employeeTypeID = Convert.ToInt32( Console.ReadLine());

            employees.Name= employeeName;
            employees.EmployeeTypeID = employeeTypeID;

            // ====Pass data to factory====
            BaseEmployeeFactory employeeManagerFactory = new EmployeeManagerFactory().CreateFectory(employees);            
            employeeManagerFactory.ApplySalary();

            //======= Print Employee Details ======
            Console.WriteLine("Employee Name:- " + employees.Name);
            Console.WriteLine("Employee Bonus:- "+ employees.HourlyPay);
            Console.WriteLine("Employee Bonus:- "+ employees.Bonus);
            Console.WriteLine("Employee MedicalAllowance:- " + employees.MedicalAllowance);
            Console.WriteLine("Employee HourseAllowance:- " + employees.HourseAllowance);

        }
    }
}
