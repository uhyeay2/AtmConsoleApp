using System;
namespace ATMConsoleApplication
{
    public class Transactions
    {
        public double Deposit(User user, double amount) => user.GetUserBalance() + amount;

        public double Withdrawl(User user, double amount)
        {
            return 0;
        }


    }
}

