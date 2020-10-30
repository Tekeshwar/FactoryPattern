using AppSimpleFactory.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppSimpleFactory.Factory
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