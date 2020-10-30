using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppSimpleFactory.Manager
{
    public class ContractorEmployeeManager : IEmployeeManager
    {
        decimal IEmployeeManager.GetBonus()
        {
            return 20;
        }

        decimal IEmployeeManager.GetPay()
        {
            return 10;
        }
    }
}