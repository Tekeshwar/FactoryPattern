using App.SimpleFactory.Manager;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.SimpleFactory.Factory
{
    public class EmployeeManagerFactory
    {
        public IEmployeeManager GetEmployeeManager(int empId)
        {
            IEmployeeManager employeeManager = null;

            if (empId == 1)
            {
                employeeManager = new ContractorEmployeeManager();
            }
            if (empId == 2)
            {
                employeeManager = new PermanentEmployeeManager();
            }

            return employeeManager;
        }
    }
}
