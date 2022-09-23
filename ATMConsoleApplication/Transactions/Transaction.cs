namespace ATMConsoleApplication.Transactions
{
    public abstract class Transaction
    {
        public Transaction(double amount, string accountNumber)
        {
            Amount = amount;
            AccountNumber = accountNumber;
        }

        public double Amount { get; set; }

        public string AccountNumber { get; set; }

        public abstract void RunTransaction();
    }
}
