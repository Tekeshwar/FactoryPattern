using App.SimpleFactory.Manager;
using App.SimpleFactory.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.SimpleFactory.Factory.FactoryMethod
{
    public abstract class BaseEmployeeFactory
    {
       protected Employees _emp;
        public BaseEmployeeFactory(Employees emp)
        {
            _emp = emp;
        }

        public Employees ApplySalary()
        {
            IEmployeeManager manager = this.Create();
            _emp.HourlyPay = manager.GetPay();
            _emp.Bonus = manager.GetBonus();
            return _emp;
        }

        protected abstract IEmployeeManager Create();
    }
}
