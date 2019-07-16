using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OOP2
{
    [Serializable]
    public class BankAccount
    {
        public string Number { get; set; }
        public bool SMSNotification { get; set; } = false;
        public string TypeOfBankAccount { get; set; }
        public int Balance { get; set; }
        public bool InternetBanking { get; set; } = false;
        public bool Secure { get; set; } = false;
        public Owner owner;

        public BankAccount(string number, string typeOfBankAccount, int balance, Owner owner)
        {
            Number = number;
            TypeOfBankAccount = typeOfBankAccount;
            Balance = balance;
            this.owner = owner;
        }
        public BankAccount() { }
    }
    [Serializable]
    public class Owner
    {
        public string Name { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender gender { get; set; } = 0;

        public Owner(string name, string secondName, string thirdName, DateTime dateOfBirth, int gen)
        {
            Name = name;
            SecondName = secondName;
            ThirdName = thirdName;
            DateOfBirth = dateOfBirth;
            gender = (Gender)gen;
        }
        public Owner() { }
    }
    public enum Gender { Male = 0, Female = 1}
    
}
