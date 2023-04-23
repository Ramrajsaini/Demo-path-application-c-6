using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_path_application_c__6
{
    internal class utilities
    {
        public static void UsingNamedArguments()
        {
            int amount = 1234;
            int months = 12;
            int bonus = 1000;
            int yearlyWageForEmployee = CalculateYearlyWage(bonus: bonus, monthlyWage: months, numberOfMonthworked: amount);
            Console.WriteLine($"Yearly wage for employee (ramraj):{yearlyWageForEmployee}");

        }
        public static int CalculateYearlyWage(int monthlyWage, int numberOfMonthworked)
        {
            if (numberOfMonthworked == 12)//let's add a bonus month
                return monthlyWage * (numberOfMonthworked + 1);

            return monthlyWage * numberOfMonthworked;
        }
        public static int CalculateYearlyWage(int monthlyWage, int numberOfMonthworked,int bonus)
        {
            Console.WriteLine($"The Yearly Wage is:{monthlyWage*numberOfMonthworked+bonus}");

            return monthlyWage * numberOfMonthworked+bonus;
        }
       
        public static double CalculateYearlyWage(double monthlyWage, double numberOfMonthworked, double bonus)
        {
            Console.WriteLine($"The Yearly Wage is:{monthlyWage * numberOfMonthworked + bonus}");

            return monthlyWage * numberOfMonthworked + bonus;
        }
    }
}
