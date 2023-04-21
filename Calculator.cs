using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleFinanceCalculator
{
    internal class Calculator
    {


        public Calculator() { }


        public decimal CalculateSimpleInterest(decimal principal, decimal rate, int years)
        {
            decimal simpleInterest = principal * rate * years;
            return simpleInterest;
        }

        public decimal CalculateSimpleInterestTerm(decimal principal, decimal rate, decimal interest)
        {
            decimal term = interest / (principal * rate);
            return term;
        }

        public decimal CalculateSimpleInterestMonthlyRepayments(decimal principal, decimal rate, int term)
        {
            decimal interest = principal * rate * term;
            decimal totalAmount = principal + interest;
            decimal monthlyRepayment = totalAmount / (term * 12);
            return monthlyRepayment;
        }
    }
}
