using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBank
{

    public delegate void AccountHandler(string message);

    public class Account
    {
        public delegate void BankOperationsHandler(Account sender, OperationsBankEventArgs e);

        public static int amountUsers = 0;
        public string Name { get; set; }
        public string Surname { get; set; }
        public string CardNumber { get; private set; }
        public float Balance { get; set; }
        public int Pin { get; private set; }
        private float balanceUsd;
        private float exchangeRate;

        AccountHandler info;



        public Account(string name, string surname, string cardNumber, int pin, float balance)

        {
            Name = name;
            Surname = surname;
            CardNumber = cardNumber;
            Pin = pin;
            Balance = balance;
            amountUsers++;
            this.balanceUsd = 0;
            this.exchangeRate = 38;
        }
        public float BalanceUsd
        {
            get { return balanceUsd; }
            set { balanceUsd = value; }
        }

        public float ExchangeRate
        {
            get { return exchangeRate; }
            set { exchangeRate = value; }
        }
        public void RegisterHandler(AccountHandler del)
        {
            info = del;
        }
        public void AddUsd(float amount)
        {
            balanceUsd += amount;
        }

        public void SubtractUsd(float amount)
        {
            balanceUsd -= amount;
        }

        public void PrintInfo()
        {
            info?.Invoke($"Ім'я: {Name}\nПрізвище: {Surname}\nНомер картки: {CardNumber}\nБаланс: {Balance}");
        }

        public void PrintBalance()
        {
            info?.Invoke($"Баланс: {Balance}");
        }

    }
}

