using InterestCalculator.AccountType;

namespace InterestCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IAccount> accounts = new List<IAccount>()
            {
                new StandartAccount(60000),
                new StandartAccount(5000),
                new StandartAccount(900),
                new SalaryAccount(70000)
            };

            foreach (var account in accounts)
                Calculator.Execute(account);
            
            Console.ReadLine();
        }
    }
}