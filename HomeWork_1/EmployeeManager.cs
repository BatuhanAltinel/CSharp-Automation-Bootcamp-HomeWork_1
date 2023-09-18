using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_1
{
    internal class EmployeeManager
    {
        public double CalculateSalary(Employee emp)
        {
            double salary;

            if(emp.TotalWorkTime <= 8)
                salary = emp.PricePerHour * emp.TotalWorkTime;
            else
            {
                double extraTime = emp.TotalWorkTime % 8;
                salary = (emp.TotalWorkTime + extraTime ) * emp.PricePerHour;
            }

            return salary / 3600;
        }
    }
}
