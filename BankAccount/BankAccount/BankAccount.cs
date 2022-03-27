using System;

namespace BankAccount
{
    public abstract class BankAccount
    {


        private string bankAccountNickName;
        private int accountNumber;
        private int routingNumber;
        private string denomination;
        private double balance;

        public double Balance { get => balance; set => balance = value; }
        public string Denomination { get => denomination; set => denomination = value; }
        public int RoutingNumber { get => routingNumber; set => routingNumber = value; }
        public int AccountNumber { get => accountNumber; set => accountNumber = value; }
        public string BankAccountNickName { get => bankAccountNickName; set => bankAccountNickName = value; }

        public BankAccount()
        {

        }

        public BankAccount(string BankAccountNickName, int AccountNumber, int RoutingNumber, string Denomination, double Balance)
        {
            bankAccountNickName = BankAccountNickName;
            accountNumber = AccountNumber;
            routingNumber = RoutingNumber;
            denomination = Denomination;
            balance = Balance;
        }



        public abstract double Withdraw(double withdrawl);

        public abstract double Deposit(double deposit);





    }
}
