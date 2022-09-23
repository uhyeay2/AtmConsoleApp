namespace ATMConsoleApplication.Accounts
{
    public abstract class Account
    {
        public decimal _balance { get; set; }

        public string _accountNumber { get; set; }

        public int MemberId { get; set; }

        public Account(decimal balance, string accountNumber, int memberId)
        {
            _balance = balance;
            _accountNumber = accountNumber;
            MemberId = memberId;
        }

        public decimal GetBalance() => _balance;

        public void Deposit(decimal amount) => _balance += amount;

        public void Withdraw(decimal amount) => _balance -= amount;
    }
}
