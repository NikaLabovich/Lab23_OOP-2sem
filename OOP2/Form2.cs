using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace OOP2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        List<BankAccount> searchedAccounts = null;
        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    searchedAccounts = Form1.Accounts.Where(p => Regex.IsMatch(p.Number, textBox1.Text)).ToList();
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    searchedAccounts = Form1.Accounts.Where(p => Regex.IsMatch($"{p.owner.SecondName} {p.owner.Name} {p.owner.ThirdName}", textBox1.Text)).ToList();
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    searchedAccounts = Form1.Accounts.Where(p => Regex.IsMatch(p.Balance.ToString(), textBox1.Text)).ToList();
                }
                else 
                {
                    searchedAccounts = Form1.Accounts.Where(p => Regex.IsMatch(p.TypeOfBankAccount, textBox1.Text)).ToList();
                }
            }
            else
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    searchedAccounts = Form1.Accounts.Where(p => p.Number == textBox1.Text).ToList();

                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    searchedAccounts = Form1.Accounts.Where(p => $"{p.owner.SecondName} {p.owner.Name} {p.owner.ThirdName}" == textBox1.Text).ToList();
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    searchedAccounts = Form1.Accounts.Where(p => p.Balance.ToString() == textBox1.Text).ToList();
                }
                else
                {
                    searchedAccounts = Form1.Accounts.Where(p => p.TypeOfBankAccount == textBox1.Text).ToList();
                }
            }

            richTextBox1.Clear();
            for (int i = 0; i < searchedAccounts.Count; i++)
            {
                BankAccount BankAccount2 = searchedAccounts[i];
                richTextBox1.Text += BankAccount2.owner.SecondName + " " + BankAccount2.owner.Name + " " + BankAccount2.owner.ThirdName + '\n'
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
            XmlSerializer formatter = new XmlSerializer(typeof(List<BankAccount>));
            using (FileStream fs = new FileStream("SearchedBankAccounts.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, searchedAccounts);
            }
        }
    }
}
