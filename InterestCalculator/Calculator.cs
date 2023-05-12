using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterestCalculator.AccountType;

namespace InterestCalculator
{
    public static class Calculator
    {
        public static void Execute(IAccount account)
        {
            account.CalculateInterest();

            Console.WriteLine($"Тип учетной записи: {account.AccountType}\n Баланс: {account.Balance}\n Процентная ставка: {account.Interest}\n");
        }
    }
}
