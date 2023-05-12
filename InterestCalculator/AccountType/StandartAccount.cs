using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestCalculator.AccountType
{
    public class StandartAccount : IAccount
    {
        public string AccountType { get; }
        public double Balance { get; }
        public double Interest { get; set; }
        public StandartAccount(double balance) 
        {
            AccountType = "Standart"; 

            Balance = balance;
        }
        public void CalculateInterest()
        {
            Interest = Balance * 0.5;
        }
    }
}
