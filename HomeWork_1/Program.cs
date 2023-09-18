using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            TimeZoneInfo GermanyTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Central Europe Standard Time");
            DateTime startDate = TimeZoneInfo.ConvertTime(DateTime.Now, GermanyTimeZone);


            Console.Write("Çalışan adını giriniz: ");
            string name = Console.ReadLine();

            Console.Write("Çalışan soy adını giriniz: ");
            string surname = Console.ReadLine();

            Console.WriteLine($"Çalışan işe başlama vakti Almanyada şu an: {startDate}");

            Console.WriteLine($"Lütfen çalışanın işi bıraktığı tarihi belirtiniz : ");
            string finishWorkTime = Console.ReadLine();

            DateTime finish = DateTime.Parse(finishWorkTime);

            Employee employee = new Employee(name, surname, startDate,finish,50);

            EmployeeManager EmpManager = new EmployeeManager();

            double salary = EmpManager.CalculateSalary(employee);

            Console.WriteLine($"Çalışanın bu mesaiden aldığı maaş : {salary}");

            Console.ReadLine();
        }
    }
}
