using App.SimpleFactory.Manager;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.SimpleFactory.Manager
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

       public int  GetMedicalAllowance()
        {
            return 100;
        }
    }
}