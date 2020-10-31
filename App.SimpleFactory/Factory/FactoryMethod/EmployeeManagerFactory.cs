using App.SimpleFactory.Manager;
using App.SimpleFactory.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.SimpleFactory.Factory.FactoryMethod
{
   public class EmployeeManagerFactory
    {
        public BaseEmployeeFactory CreateFectory(Employees emp)
        {
            BaseEmployeeFactory baseReturnValue=null;
            if (emp.EmployeeTypeID==1)
            {
                baseReturnValue = new ContractEmployeeFactory(emp);
            }

            if (emp.EmployeeTypeID == 2)
            {
                baseReturnValue = new PermanentEmployeeFactory(emp);
                
            }
            return baseReturnValue;
        }
    }
}
