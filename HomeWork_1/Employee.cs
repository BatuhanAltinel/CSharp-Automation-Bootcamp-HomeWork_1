using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_1
{
    internal class Employee
    {
        public string Name { get; }
        public string Surname { get; }
        public DateTime StartTime { get; }
        public DateTime FinishTime { get; }
        public int TotalWorkTime { get; set; }
        public double PricePerHour { get;}

        public Employee(string name, string surname,DateTime startDate,DateTime finishDate,double pricePerHour)
        {
            Name = name;
            Surname = surname;
            StartTime = startDate;
            FinishTime = finishDate;
            PricePerHour = pricePerHour;

            TimeSpan totalWorkTime = FinishTime - StartTime ;

            TotalWorkTime = totalWorkTime.Seconds + (totalWorkTime.Hours * 3600);
            Console.WriteLine("Total work seconds == " + TotalWorkTime);
        }



    }
}
