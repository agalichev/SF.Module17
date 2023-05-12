using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestCalculator.AccountType
{
    public interface IAccount
    {
        string AccountType { get; }
        double Balance { get; }
        double Interest { get; set; }
        void CalculateInterest();
    }
}
