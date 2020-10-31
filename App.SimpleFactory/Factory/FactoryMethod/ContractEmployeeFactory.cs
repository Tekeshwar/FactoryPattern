using App.SimpleFactory.Manager;
using App.SimpleFactory.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.SimpleFactory.Factory.FactoryMethod
{
    public class ContractEmployeeFactory : BaseEmployeeFactory
    {
        public ContractEmployeeFactory(Employees emp) : base(emp)
        {

        }
        protected override IEmployeeManager Create()
        {
            ContractorEmployeeManager manager = new ContractorEmployeeManager();
            _emp.MedicalAllowance = manager.GetMedicalAllowance();
            return manager;
        }
    }
}
