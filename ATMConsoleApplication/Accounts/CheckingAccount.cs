namespace ATMConsoleApplication.Accounts
{
    public class CheckingAccount : Account
    {
        public CheckingAccount(decimal balance, string accountNumber, int memberId) : base(balance, accountNumber, memberId)
        {
        }
    }
}
