using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBank
{

    public class AutomatedTellerMachine
    {
        private float ConvertUsdToUan(float usdAmount, float exchangeRate)
        {
            return usdAmount * exchangeRate;
        }
        public delegate void BankOperationsHandler(AutomatedTellerMachine sender, OperationsBankEventArgs e);
        public event BankOperationsHandler Notify;
        public float Money { get; set; }
        public string IdATMs { get; protected set; }
        public string Address { get; protected set; }

        public AutomatedTellerMachine(float money, string idATMs, string address)
        {
            Money = money;
            IdATMs = idATMs;
            Address = address;
        }

        public void Put(float sum, Account[] account, int user)
        {
            account[user].Balance += sum;
            Money += sum;
            Notify?.Invoke(this, new OperationsBankEventArgs($"На рахунок зараховано {sum} UAN", sum));
        }



        public void Take(float sum, Account[] account, int user)
        {
            if (account[user] != null)
            {
                if (Money >= sum)
                {
                    if (account[user].Balance >= sum)
                    {
                        account[user].Balance -= sum;
                        Money -= sum;
                        Notify?.Invoke(this, new OperationsBankEventArgs($"{sum} UAN було знято з рахунку", sum));
                    }
                    else
                    {
                        Notify?.Invoke(this, new OperationsBankEventArgs("Недостатньо коштів на рахунку", sum));
                    }
                }
                else
                {
                    Notify?.Invoke(this, new OperationsBankEventArgs("Вибачте, наразі ви не можете зняти кошти через технічні проблеми банку", sum));
                }
            }
        }

        public void TakeUsd(float sum, Account[] account, int user)
        {
            float equivalentUan = sum * account[user].ExchangeRate;

            if (account[user] != null)
            {
                if (Money >= equivalentUan)
                {
                    if (account[user].BalanceUsd >= sum)
                    {
                        account[user].SubtractUsd(sum);
                        Money -= equivalentUan;
                        Notify?.Invoke(this, new OperationsBankEventArgs($"{sum} {currentCurrency} було знято з рахунку", equivalentUan));
                    }
                    else
                    {
                        Notify?.Invoke(this, new OperationsBankEventArgs($"Недостатньо коштів на рахунку в {currentCurrency}", equivalentUan));
                    }
                }
                else
                {
                    Notify?.Invoke(this, new OperationsBankEventArgs($"Вибачте, наразі ви не можете зняти кошти в {currentCurrency} через технічні проблеми банку", equivalentUan));
                }
            }
        }

        public void PutUsd(float sum, Account[] accounts, int user)
        {
            float equivalentUan = ConvertUsdToUan(sum, accounts[user].ExchangeRate);


            accounts[user].BalanceUsd += sum;
            accounts[user].Balance += equivalentUan;


            Notify?.Invoke(this, new OperationsBankEventArgs($"Поповнено рахунок на {sum} USD ({equivalentUan} UAN) в доларах.", equivalentUan));
        }

        public bool CardTransfer(float sum, string cardNumber, Account[] account, int user)
        {
            bool check = false;
            if (account[user].Balance >= sum)
            {
                if (!check)
                {
                    for (int j = 0; j < Account.amountUsers; j++)
                    {
                        if (account[j].CardNumber == cardNumber)
                        {
                            check = true;
                            float equivalentSum = sum * account[user].ExchangeRate;
                            account[j].Balance += equivalentSum;
                            account[user].Balance -= sum;
                            Notify?.Invoke(this, new OperationsBankEventArgs($"{equivalentSum} UAN було переведено на картку за номером {cardNumber}", equivalentSum));
                            return true;
                        }
                    }

                    if (!check)
                    {
                        Notify?.Invoke(this, new OperationsBankEventArgs($"Картку за номером {cardNumber} не знайдено", sum));
                    }
                }
            }
            else
            {
                Notify?.Invoke(this, new OperationsBankEventArgs("Недостатньо коштів на рахунку", sum));
                return false;
            }
            return false;
        }
        private Currency currentCurrency = Currency.UAH;

        public enum Currency
        {
            UAH,
            USD
        }

        public void SetCurrency(Currency currency)
        {
            currentCurrency = currency;
        }
        public Currency GetCurrency()
        {
            return currentCurrency;
        }
    }

}
