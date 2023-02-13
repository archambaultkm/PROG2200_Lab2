using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class SalaryCalculator
    {
        const int HoursInYear = 2080;

        public decimal GetAnnualSalary(decimal hourlyWage) => hourlyWage * HoursInYear;       
        public decimal GetHourlyWage(int annualSalary) => annualSalary / HoursInYear;
        
        public TaxData TaxWithheld(double weeklySalary, int numDependants)
        {
            double ProvincialTaxWithheld = 0.6 * weeklySalary;
            double FederalTaxWithheld = 0.25 * weeklySalary;
            double DependantDeduction = (numDependants * 0.2) * weeklySalary;
            double TotalWithheld = ProvincialTaxWithheld + FederalTaxWithheld - DependantDeduction;
            double TotalTakeHome = weeklySalary - TotalWithheld;
            
            TaxData td = new TaxData(ProvincialTaxWithheld, FederalTaxWithheld, DependantDeduction, TotalWithheld, TotalTakeHome);

            return td;
        }
    }
}
