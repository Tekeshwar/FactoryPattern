using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppSimpleFactory.Manager
{
    public class PermanentEmployeeManager : IEmployeeManager
    {
        decimal IEmployeeManager.GetBonus()
        {
            return 50;
        }

        decimal IEmployeeManager.GetPay()
        {
            return 100;
        }
    }
}