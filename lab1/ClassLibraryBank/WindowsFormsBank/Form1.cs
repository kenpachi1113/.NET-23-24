using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryBank;

namespace WindowsFormsBank
{
    public partial class Form1 : Form
    {
        Account[] account =
               {   new Account ("Kyrylo", "Bozhko ", "5375 4114 1883 1397", 1111, 15290),
                   new Account ("Renat", "Kramarovsky", "5335 4141 2596 1007", 2222, 11200),
                   new Account ("Oleksii", "Kolesnyk", "5335 4141 2598 1007", 3333, 12000),
                   new Account ("Danylo", "Govorun", "5956 4114 2612 9436", 4444, 9000),
                   new Account ("Nikita ", "Motytskyi", "5849 4141 2596 1000", 5555, 20000),
               };
        AutomatedTellerMachine ATM = new AutomatedTellerMachine(10000000000, "#123456789", " вул. Чуднівська, 103");
        Bank bank = new Bank("MONO24", 1);
        int user;
        public Form1()
        {

            InitializeComponent();
            groupBoxOperations.Visible = false;
            label4.Visible = false;
            textBoxCard.Visible = false;
            TransferCard.Visible = false;


        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (checkBoxNotify.Checked == true) { ATM.Notify -= DisplayMessage; }
            if (checkBoxNotify.Checked == false) { ATM.Notify += DisplayMessage; }
            bank.Notifications += PrintInfo;
            account[user].RegisterHandler(PrintInfo);
            textBoxPin.PasswordChar = '*';
        }
        float CheckFloat(string text)
        {
            bool f;
            float x;
            do
            {
                f = float.TryParse(text, out x);
                if (f == false)
                {
                    MessageBox.Show("Помилка введення значення. Будь-ласка, повторіть введення ще раз!", "Помилка",
         MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            } while (!f);
            return x;
        }

        int CheckInt(string text)
        {
            bool f;
            int x;
            do
            {
                f = int.TryParse(text, out x);
                if (f == false)
                {
                    MessageBox.Show("Помилка введення значення. Будь-ласка, повторіть введення ще раз!", "Помилка",
         MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            } while (!f);
            return x;
        }
        private string CheckString(string text)
        {
            string input;
            do
            {
                input = text;
                if (string.IsNullOrWhiteSpace(input))
                {
                    MessageBox.Show("Помилка введення значення. Будь-ласка, повторіть введення ще раз!", "Помилка",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxCardNum.Clear();
                }
            } while (string.IsNullOrWhiteSpace(input));

            return input;
        }
        private void buttonAutification_Click(object sender, EventArgs e)
        {
            string card = CheckString(textBoxCardNum.Text);
            int pin = CheckInt(textBoxPin.Text);
            bool fl = bank.Authentication(card, pin, account, out user);

            if (fl == true)
            {
                groupBoxAutification.Visible = false;
                groupBoxOperations.Visible = true;
                textBoxCardNum.Text = "";
                textBoxPin.Text = "";
            }
            if (fl == false)
            {
                textBoxCardNum.Text = "";
                textBoxPin.Text = "";
            }

        }
        void PrintInfo(string message)
        {
            MessageBox.Show($"{message}");
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            groupBoxOperations.Visible = false;
            groupBoxAutification.Visible = true;
        }

        private void buttonTake_Click(object sender, EventArgs e)
        {
            float take = CheckFloat(textBoxOperations.Text); ATM.Take(take, account, user);
            groupBoxButtons.Visible = true;
            labelBalance.Text = $"Баланс: {account[user].Balance}";
        }
        void DisplayMessage(AutomatedTellerMachine sender, OperationsBankEventArgs e)
        {
            MessageBox.Show($"Сумма транзакції: {e.Sum}UAN");
            MessageBox.Show(e.Message);
        }

        private void buttonTran_Click(object sender, EventArgs e)
        {
            label4.Visible = true;
            textBoxCard.Visible = true;
            TransferCard.Visible = true;
            groupBoxButtons.Visible = false;
        }

        private void TransferCard_Click(object sender, EventArgs e)
        {
            float sum = CheckFloat(textBoxOperations.Text);
            string card = CheckString(textBoxCard.Text);
            bool flag = ATM.CardTransfer(sum, card, account, user);

            if (flag == true)
            {
                label4.Visible = false;
                textBoxCard.Visible = false;
                TransferCard.Visible = false;
                groupBoxButtons.Visible = true;
                labelBalance.Text = $"Баланс: {account[user].Balance}";
            }


        }

        private void buttonPut_Click(object sender, EventArgs e)
        {
            float take = CheckFloat(textBoxOperations.Text); ATM.Put(take, account, user);
            groupBoxButtons.Visible = true;
            labelBalance.Text = $"Баланс: {account[user].Balance}";
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            account[user].PrintInfo();
        }

        private void groupBoxOperations_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
