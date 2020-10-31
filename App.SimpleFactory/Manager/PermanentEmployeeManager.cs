using System;
using System.Collections.Generic;
using System.Text;

namespace App.SimpleFactory.Manager
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
      public  int GetHourseAllowance()
        {
            return 150;
        }
    }
}
