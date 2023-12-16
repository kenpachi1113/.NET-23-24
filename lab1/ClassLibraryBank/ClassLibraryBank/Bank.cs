using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBank
{
    public delegate void BankHandler(string message);
    public class Bank
    {
        public delegate void BanksHandler(Bank sender, BanksEventArgs e);
        public event BankHandler Notifications;
        public string BankName { get; private set; }
        public int ListOfATMs { get; set; }

        public Bank(string bankName, int listOfATMs)
        {
            BankName = bankName;
            ListOfATMs = listOfATMs;
        }


       
        public bool Authentication(string cardNumber, int pin, Account[] accounts, out int user)
        {
            user = -1;
            for (int i = 0; i < Account.amountUsers; i++)
            {
                if (accounts[i].CardNumber == cardNumber)
                {
                    if (accounts[i].Pin == pin)
                    {
                        user = i;
                        Notifications?.Invoke("Aутентифікація успішна!");
                        return true;
                    }
                    else
                    {
                        Notifications?.Invoke("Помилка введення даних! Повторіть спробу!");
                        return false;
                    }
                }
            }

            Notifications?.Invoke("Аккаунт не знайдено! Перевірте номер картки.");
            return false;
        }

    }
}
