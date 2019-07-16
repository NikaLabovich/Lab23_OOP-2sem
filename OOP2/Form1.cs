using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace OOP2
{
    public partial class Form1 : Form
    {
        List<BankAccount> sortedAccounts = null;
        public static List<BankAccount> Accounts = new List<BankAccount>();
        Owner AccountOwner = new Owner();
        BankAccount BankAccountOwner = new BankAccount();
        public Form1()
        {
            InitializeComponent();
            comboBox_typeOfBankAccount.SelectedIndex = 0;
            domainUpDown_Gender.SelectedIndex = 0;
        }

        private void TrackBar_Balance_Scroll(object sender, EventArgs e)
        {
            label_BalanceValue.Text = "Баланс: " + trackBar_Balance.Value;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button_Add_Click(object sender, EventArgs e)
        {
            try
            {
                bool isOwnerOk = true;
                if (textBox_OwnerName.Text == "" || textBox_OwnerSecondName.Text == "" || textBox_OwnerThridName.Text == "")
                {
                    isOwnerOk = false;
                }
                if (isOwnerOk)
                {
                    Owner tempOwner = new Owner(textBox_OwnerName.Text, textBox_OwnerSecondName.Text, textBox_OwnerThridName.Text, dateTimePicker_DateOfBirth.Value, domainUpDown_Gender.SelectedIndex);
                    AccountOwner = tempOwner;
                }
                else
                {
                    throw new Exception("Не все поля заполнены!");
                }

                bool isAccountOk = true;
                if (textBox_BankAccount.Text == "" || trackBar_Balance.Value == 0)
                {
                    isAccountOk = false;
                }
                if (isAccountOk)
                {
                    BankAccount tempAccountOwner = new BankAccount(textBox_BankAccount.Text, (string)comboBox_typeOfBankAccount.SelectedItem, trackBar_Balance.Value, AccountOwner);
                    BankAccountOwner = tempAccountOwner;
                    Accounts.Add(BankAccountOwner);
                }
                else
                {
                    throw new Exception("Не все поля заполнены!");
                }
                foreach (RadioButton radio in groupBox_IsSmsEnabled.Controls)
                {
                    if (radio.Checked && radio.Text == "Да")
                    {
                        BankAccountOwner.SMSNotification = true;
                    }
                    else
                    {
                        BankAccountOwner.SMSNotification = false;
                    }
                }
                if (checkBox_InternetBanking.Checked)
                {
                    BankAccountOwner.InternetBanking = true;
                }
                if (checkBox_3DSecure.Checked)
                {
                    BankAccountOwner.Secure = true;
                }

                    richTextBox_toOutput.Text += BankAccountOwner.owner.SecondName + " " + BankAccountOwner.owner.Name + " " + BankAccountOwner.owner.ThirdName + '\n'
                   + "Дата рождения: " + BankAccountOwner.owner.DateOfBirth.ToShortDateString() + '\n'
                   + "Пол: " + BankAccountOwner.owner.gender.ToString() + '\n'
                   + "Номер счета: " + BankAccountOwner.Number + '\n'
                   + "Тип счета: " + BankAccountOwner.TypeOfBankAccount + '\n'
                   + "Баланс: " + BankAccountOwner.Balance + '\n'
                   + "" + '\n'
                   + "SMS-оповещения: " + BankAccountOwner.SMSNotification + '\n'
                   + "Интернет-банкинг: " + BankAccountOwner.InternetBanking + '\n'
                   + "3DSecure: " + BankAccountOwner.Secure + '\n' 
                   + "------------------------------------------\n";

              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_ReadXML_Click(object sender, EventArgs e)
        {
            //Десериализация из XML
            try
            {
                XmlSerializer formatter = new XmlSerializer(typeof(List<BankAccount>));
            
                using (FileStream fs = new FileStream("BankAccount.xml", FileMode.OpenOrCreate))
                {
                    Accounts = (List<BankAccount>)formatter.Deserialize(fs);
                    
                }

                richTextBox_toOutput.Clear();
                for (int i = 0; i < Accounts.Count; i++)
                {
                    BankAccount BankAccount2 = Accounts[i];
                    richTextBox_toOutput.Text += BankAccount2.owner.SecondName + " " + BankAccount2.owner.Name + " " + BankAccount2.owner.ThirdName + '\n'
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
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void Button_SaveXML_Click(object sender, EventArgs e)
        {
            //Сериализуем в XML
            XmlSerializer formatter = new XmlSerializer(typeof(List<BankAccount>));
            using (FileStream fs = new FileStream("BankAccount.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, Accounts);
            }
        }

        private void label_TypeOfBankAccount_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_typeOfBankAccount_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label_BancAccount_Click(object sender, EventArgs e)
        {

        }

        private void radioButton_SmsFalse_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton_SmsTrue_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox_toOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void DepositTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            sortedAccounts =  Accounts.OrderBy(account => account.TypeOfBankAccount).ToList();
            richTextBox_toOutput.Clear();
            for (int i = 0; i < sortedAccounts.Count; i++)
            {
                BankAccount BankAccount2 = sortedAccounts[i];
                richTextBox_toOutput.Text += BankAccount2.owner.SecondName + " " + BankAccount2.owner.Name + " " + BankAccount2.owner.ThirdName + '\n'
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

        private void DateOfOpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sortedAccounts = Accounts.OrderBy(account => account.owner.DateOfBirth).ToList();
            richTextBox_toOutput.Clear();
            for (int i = 0; i < sortedAccounts.Count; i++)
            {
                BankAccount BankAccount2 = sortedAccounts[i];
                richTextBox_toOutput.Text += BankAccount2.owner.SecondName + " " + BankAccount2.owner.Name + " " + BankAccount2.owner.ThirdName + '\n'
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

        private void сортировкаПоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void AboutProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(c) Лобович Вероника Валерьевна\nv 1.0");
        }

        private void поискToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<BankAccount>));
            using (FileStream fs = new FileStream("SortedBankAccount.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, sortedAccounts);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox_toOutput.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string path = "BankAccount.xml";
            if (File.Exists(path))
                File.Delete(path);
            else
                MessageBox.Show("Файл не найден");

        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
