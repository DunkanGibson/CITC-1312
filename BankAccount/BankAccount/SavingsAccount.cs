using System;
namespace BankAccount
{
    public class SavingsAccount : BankAccount
    {
        private int numberOfWithdrawls = 0;

        public SavingsAccount()
        {
        }

        public SavingsAccount(string bankAccountNickName, int accountNumber, int routingNumber, string denomination, double balance)
        {
            BankAccountNickName = bankAccountNickName;
            AccountNumber = accountNumber;
            RoutingNumber = routingNumber;
            Denomination = denomination;
            Balance = balance;
        }

        public override double Withdraw(double withdrawlAmmount)
        {
            if (numberOfWithdrawls < 5)
            {
                numberOfWithdrawls++;
                return Balance - withdrawlAmmount;
            }

            return 0;
        }

        public override double Deposit(double depositAmmount)
        {
            return Balance + depositAmmount;
        }
    }
}
