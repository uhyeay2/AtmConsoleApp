using ATMConsoleApplication.Accounts;

namespace ATMConsoleApplication
{
    public class User
    {
        private int MemberId;

        private int _pin;

        public string FirstName { get; set; }
        
        public string LastName { get; set; }

        private List<Account> Accounts { get; set; } = new List<Account>(); 

        public User(string firstName, string lastName, int memberId, int pin)
        {
            _pin = pin;
            MemberId = memberId;
            FirstName = firstName;
            LastName = lastName;
        }

        public void AddNewAccount(Account account) => Accounts.Add(account);

    }
}

