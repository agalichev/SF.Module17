using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestCalculator.AccountType
{
    internal class SalaryAccount : IAccount
    {
        public string AccountType { get; }
        public double Balance { get; }
        public double Interest { get; set; }
        public SalaryAccount(double balance) 
        {
            AccountType = "Salary";

            Balance = balance;
        }
        public void CalculateInterest()
        {
            Interest = Balance * 0.4;

            if (Balance < 1000)
                Interest -= Balance * 0.2;

            if (Balance < 50000)
                Interest -= Balance * 0.4;
        }
    }
}
