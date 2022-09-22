using System;
namespace ATMConsoleApplication
{
    public class User
    {
        private int _cardNum;
        private double _balance;
        private int _pin;


        public string FirstName { get; set; }
        public string LastName { get; set; }




        public User(double balance, int pin, string firstName, string lastName)
        {
            Random rnd = new Random();
            _cardNum = rnd.Next(10000000, 1000000000);
            _balance = balance;
            _pin = pin;

            FirstName = firstName;
            LastName = lastName;

        }

        public int GetUserCardNum()
        {
            return _cardNum;
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

