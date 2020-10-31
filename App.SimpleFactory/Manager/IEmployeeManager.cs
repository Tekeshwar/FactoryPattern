using System;
using System.Collections.Generic;
using System.Text;

namespace App.SimpleFactory.Manager
{
  public  interface IEmployeeManager
    {
        decimal GetBonus();
        decimal GetPay();
    }
}
