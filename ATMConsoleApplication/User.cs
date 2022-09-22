using System;
namespace ATMConsoleApplication
{
    public class User
    {
        private int _accountNumber;
        private double _balance;
        private int _pin;


        public string FirstName { get; set; }
        public string LastName { get; set; }




        public User(string firstName, string lastName, double balance, int pin)
        {
            Random rnd = new Random();
            _accountNumber = rnd.Next(10000000, 1000000000);
            _balance = balance;
            _pin = pin;

            FirstName = firstName;
            LastName = lastName;

        }

        public int GetUserCardNum()
        {
            return _accountNumber;
        }

        public double GetUserBalance()
        {
            return _balance;
        }

        public int GetUserPin()
        {
            return _pin;
        }

    }
}

