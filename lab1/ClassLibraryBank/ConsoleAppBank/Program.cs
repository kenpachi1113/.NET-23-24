using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryBank;

namespace ConsoleAppBank
{
    class Program
    {
        static void DisplayMessage(AutomatedTellerMachine sender, OperationsBankEventArgs e)
        {
            Console.WriteLine($"Сумма транзакції: {e.Sum} USD ({e.EquivalentUAN} UAN)");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(e.Message);
            Console.ResetColor();
        }
        static string CheckString()
        {
            string input;
            do
            {
                input = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Red;
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine(" Помилка введення значення. Будь-ласка, повторіть введення ще раз!");
                    Console.ResetColor();
                    Console.Write("Введіть значеня ще раз: ");
                }
                Console.ResetColor();
            } while (string.IsNullOrWhiteSpace(input));
            return input;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
            System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
            Console.Title = "Лабораторна робота №1 Божко К. Д , ВТ-22-2";

            float CheckFloat()
            {
                bool f;
                float x;
                do
                {
                    f = float.TryParse(Console.ReadLine(), out x);
                    Console.ForegroundColor = ConsoleColor.Red;
                    if (f == false)
                    {
                        Console.WriteLine(" Помилка введення значення. Будь-ласка, повторіть введення ще раз!");
                        Console.ResetColor();
                        Console.Write("Введіть значеня ще раз: ");
                    }
                    Console.ResetColor();
                } while (!f);
                return x;
            }
            int CheckInt()
            {
                bool f;
                int x;
                do
                {
                    f = int.TryParse(Console.ReadLine(), out x);
                    Console.ForegroundColor = ConsoleColor.Red;
                    if (f == false)
                    {
                        Console.WriteLine(" Помилка введення значення. Будь-ласка, повторіть введення ще раз!");
                        Console.ResetColor();
                        Console.Write("Введіть значеня ще раз: ");
                    }
                    Console.ResetColor();
                } while (!f);
                return x;
            }

            Account[] account =
                {  new Account ("Kyrylo", "Bozhko ", "3333", 1111, 19000),
                   new Account ("Kyrylo", "Bozhko ", "5375 4114 1883 1397", 1111, 16000),
                   new Account ("Renat", "Kramarovsky", "5335 4141 2596 1007", 2222, 11200),
                   new Account ("Oleksii", "Kolesnyk", "5335 4141 2596 1007", 3333, 12000),
                   new Account ("Danylo", "Govorun", "5956 4114 2612 9436", 4444, 9000),
                   new Account ("Nikita ", "Motytskyi", "5849 4141 2596 1000", 5555, 20000),
               };
            AutomatedTellerMachine ATM = new AutomatedTellerMachine(10000000000, "#123456789", "вул. Чуднівська, 103");
            Bank bank = new Bank("Mono24", 1);

            bank.Notifications += PrintInfo;
autification:
            int user;
            bool flag = false;
            do
            {
                Console.WriteLine("Введіть номер карти: "); string card = CheckString();
                Console.WriteLine("Введіть пароль: "); int pin = CheckInt();
                flag = bank.Authentication(card, pin, account, out user);
                Console.ReadKey();

            } while (!flag);
            Console.Clear();

            ATM.Notify += DisplayMessage;
            account[user].RegisterHandler(PrintInfo);



            int num;
            do
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n---------- Головне меню ----------\n");
                Console.ResetColor();
                Console.WriteLine("1.Вивести дані користувача.\n2.Перевірити баланс.\n3.Зняти кошти.\n4.Покласти кошти.\n5.Перевести кошти.\n6.Вийти з акаунту.\n0.Вихід з програми");
                Console.Write("Введіть пункт меню: ");
                num = CheckInt();
                switch (num)
                {
                    case 1: Console.Clear(); account[user].PrintInfo(); break;
                    case 2: Console.Clear(); account[user].PrintBalance(); break;
                    case 3: Console.Clear(); Console.Write("Введіть суму зняття: "); float take = CheckFloat(); ATM.Take(take, account, user); break;
                    case 4:
                        {
                            Console.Clear();

                            // Выбор валюты
                            Console.WriteLine("Виберіть валюту:\n1. Гривні (UAH)\n2. Доллари (USD)");
                            int currencyChoice = CheckInt();
                            if (currencyChoice == 1)
                            {
                                ATM.SetCurrency(AutomatedTellerMachine.Currency.UAH);
                            }
                            else if (currencyChoice == 2)
                            {
                                ATM.SetCurrency(AutomatedTellerMachine.Currency.USD);
                            }

                            Console.WriteLine($"Поточна валюта: {ATM.GetCurrency()}");

                            
                            Console.WriteLine("Введіть суму поповнення: ");
                            float put = CheckFloat();

                            if (ATM.GetCurrency() == AutomatedTellerMachine.Currency.UAH)
                            {
                                ATM.Put(put, account, user);
                            }
                            else if (ATM.GetCurrency() == AutomatedTellerMachine.Currency.USD)
                            {
                                ATM.PutUsd(put, account, user);
                            }
                        }
                        break;

                    case 5:
                        {
                            Console.Clear();
                            Console.Write("Введіть суму поповнення картки: ");
                            float sum = CheckFloat();
                            Console.Write("Введіть номер картки: ");
                            string cardNumber = CheckString();
                            ATM.CardTransfer(sum, cardNumber, account, user);
                        }
                        break;
                    case 6: Console.Clear(); goto autification;
                    case 7:
                        {
                            Console.Clear();
                            Console.WriteLine("Виберіть валюту:\n1. Гривні (UAH)\n2. Доллари (USD)");
                            int currencyChoice = CheckInt();
                            if (currencyChoice == 1)
                            {
                                ATM.SetCurrency(AutomatedTellerMachine.Currency.UAH);
                            }
                            else if (currencyChoice == 2)
                            {
                                ATM.SetCurrency(AutomatedTellerMachine.Currency.USD);
                            }
                            Console.WriteLine($"Валюта змінена на {ATM.GetCurrency()}");
                        }
                        break;
                }
            } while (num != 0);



            void DisplayMessage(AutomatedTellerMachine sender, OperationsBankEventArgs e)
            {
                Console.WriteLine($"Сумма транзакції: {e.Sum}UAN");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(e.Message);
                Console.ResetColor();
            }


            void PrintInfo(string message)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(message);
                Console.ResetColor();
                Console.ReadKey();
            }
        }
    }
}
