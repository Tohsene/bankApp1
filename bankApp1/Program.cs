using System;

namespace classes
{
    class OpenAcoount
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("<name>", 1000);
            Console.WriteLine($"Account {account.Number} was created for {account.Customer} with {account.Balance} initial balance.");
        }
        public class BankAccount
        {
            private static int accountNumberSeed = 1234567890;
            public string Number { get; set; }
            public string Customer { get; set; }

            public decimal Balance { get; set; }
            public DateTime Date { get; set; }


            public BankAccount(string name, decimal initialBalance)
            {
                this.Customer = name;
                this.Balance = initialBalance;
                this.Number = accountNumberSeed.ToString();
                accountNumberSeed++;
            }
            public void MakeDeposit(decimal amount, DateTime date, string note)
            {
            }

            public void MakeWithdrawal(decimal amount, DateTime date, string note)
            {
            }

            public decimal CheckBalance()
            {
                return Balance;
            }

        }
    }
}

