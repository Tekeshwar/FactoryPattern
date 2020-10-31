using System;
using System.Collections.Generic;
using System.Text;

namespace App.SimpleFactory.Model
{
   public class Employees
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string JobDescription { get; set; }
        public string Number { get; set; }
        public string Department { get; set; }
        public decimal HourlyPay { get; set; }
        public decimal Bonus { get; set; }
        public int EmployeeTypeID { get; set; }

        //public virtual Employee_Type Employee_Type { get; set; }
    }
}
