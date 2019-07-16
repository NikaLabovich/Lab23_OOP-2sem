using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        List<BankAccount> sortedAccounts = null;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            sortedAccounts = Form1.Accounts.OrderBy(account => account.TypeOfBankAccount).ToList();
            richTextBox2.Clear();
            for (int i = 0; i < sortedAccounts.Count; i++)
            {
                BankAccount BankAccount2 = sortedAccounts[i];
                richTextBox2.Text += BankAccount2.owner.SecondName + " " + BankAccount2.owner.Name + " " + BankAccount2.owner.ThirdName + '\n'
                   + "Дата рождения: " + BankAccount2.owner.DateOfBirth.ToShortDateString() + '\n'
                   + "Пол: " + BankAccount2.owner.gender.ToString() + '\n'
                   + "Номер счета: " + BankAccount2.Number + '\n'
                   + "Тип счета: " + BankAccount2.TypeOfBankAccount + '\n'
                   + "Баланс: " + BankAccount2.Balance + '\n'
                   + "" + '\n'
                   + "SMS-оповещения: " + BankAccount2.SMSNotification + '\n'
                   + "Интернет-банкинг: " + BankAccount2.InternetBanking + '\n'
                   + "3DSecure: " + BankAccount2.Secure + '\n'
                   + "------------------------------------------\n";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sortedAccounts = Form1.Accounts.OrderBy(account => account.owner.DateOfBirth).ToList();
            richTextBox2.Clear();
            for (int i = 0; i < sortedAccounts.Count; i++)
            {
                BankAccount BankAccount2 = sortedAccounts[i];
                richTextBox2.Text += BankAccount2.owner.SecondName + " " + BankAccount2.owner.Name + " " + BankAccount2.owner.ThirdName + '\n'
                   + "Дата рождения: " + BankAccount2.owner.DateOfBirth.ToShortDateString() + '\n'
                   + "Пол: " + BankAccount2.owner.gender.ToString() + '\n'
                   + "Номер счета: " + BankAccount2.Number + '\n'
                   + "Тип счета: " + BankAccount2.TypeOfBankAccount + '\n'
                   + "Баланс: " + BankAccount2.Balance + '\n'
                   + "" + '\n'
                   + "SMS-оповещения: " + BankAccount2.SMSNotification + '\n'
                   + "Интернет-банкинг: " + BankAccount2.InternetBanking + '\n'
                   + "3DSecure: " + BankAccount2.Secure + '\n'
                   + "------------------------------------------\n";
            }
        }
    }
}
