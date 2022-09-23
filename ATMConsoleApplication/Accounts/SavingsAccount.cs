namespace ATMConsoleApplication.Accounts
{
    public class SavingsAccount : Account
    {
        public SavingsAccount(decimal balance, string accountNumber, int memberId) : base(balance, accountNumber, memberId)
        {
        }
    }
}
