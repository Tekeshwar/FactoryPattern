using App.SimpleFactory.Manager;
using App.SimpleFactory.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.SimpleFactory.Factory.FactoryMethod
{
    public class PermanentEmployeeFactory : BaseEmployeeFactory
    {
        
        public PermanentEmployeeFactory(Employees emp):base( emp)
        {

        }
        protected override IEmployeeManager Create()
        {
            PermanentEmployeeManager manager = new PermanentEmployeeManager();
            _emp.HourseAllowance = manager.GetHourseAllowance();
            return manager;
        }
    }
}
