using System;
namespace BankAccount
{
    public class CheckingAccount : BankAccount
    {
        public CheckingAccount()
        {
        }


        public CheckingAccount(string bankAccountNickName, int accountNumber, int routingNumber, string denomination, double balance)
        {
            BankAccountNickName = bankAccountNickName;
            AccountNumber = accountNumber;
            RoutingNumber = routingNumber;
            Denomination = denomination;
            Balance = balance;
        }

        public override double Withdraw(double withdrawlAmmount)
        {
            return Balance - withdrawlAmmount;
        }

        public override double Deposit(double depositAmmount)
        {
            return Balance + depositAmmount;
        }

    }
}
