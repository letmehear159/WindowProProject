using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windown_programming_17_1
{
    internal class Utility
    {

        public static bool checkValidInformation(Person person)
        {
            if (!isValidValuePassed(person))
            {
                MessageBox.Show("Cannot let empty box, Please Fill in!");
                return false;
            }
            else if (!checkPhoneValid(person.getPhone()))
            {
                MessageBox.Show("Error phone number");
                return false;
            }
            else if (!checkAgeValid(person))
            {
                MessageBox.Show("Invalid Age, Must be over 17!");
                return false;
            }
            else if (!checkEmailValid(person))
            {
                MessageBox.Show("Invalid Email");
                return false;
            }
            return true;
        }
        public static bool isValidValuePassed(Person person)
        {
            if (person == null)
            {
                return false;
            }
            else if (string.IsNullOrEmpty(person.getName()) || string.IsNullOrEmpty(person.getAddress()) || string.IsNullOrEmpty(person.getCMND()))
            {
                return false;
            }
            else if (string.IsNullOrEmpty(person.getPhone()) || string.IsNullOrEmpty(person.getEmail()))
            {
                return false;
            }
            return true;
        }
        public static bool checkPhoneValid(string phoneNum)
        {
            for (int i = 0; i < phoneNum.Length; i++)
            {
                if (!char.IsDigit(phoneNum[i]))
                {
                    return false;
                }
            }
            if (!phoneNum[0].Equals('0') && !phoneNum.Substring(0, 2).Equals("84"))
            {
                return false;
            }
            if (phoneNum.Length != 10)
            {
                return false;
            }
            return true;
        }
        public static bool checkAgeValid(Person person)
        {
            int age = DateTime.Now.Year - person.getBirthDate().Year;
            if (age >= 17 && age <= 130)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool checkEmailValid(Person person)
        {
            if (!person.getEmail().Contains("@"))
            {
                return false;
            }
            string[] str = person.getEmail().Split('@');
            string localName = str[0].ToLower();
            string domain = str[1].ToLower();
            if (string.IsNullOrEmpty(localName) || string.IsNullOrEmpty(domain))
            {
                return false;
            }
            string[] domainNames = new string[]
            {
                "gmail.com","yahoo.com","outlook.com","hotmail.com"
                ,"aol.com","icloud.com","zoho.com","mail.com","gmx.com"
            };
            bool domainCheck = false;
            foreach (string domainName in domainNames)
            {
                if (domainNames.Contains(domainName))
                {
                    domainCheck = true;
                    break;
                }
            }
            if (!domainCheck)
            {
                return false;
            }
            int lastCom = domain.LastIndexOf("com");
            string afterCom = "" + domain.Substring(lastCom + 3).ToLower();
            if (!string.IsNullOrEmpty(afterCom))
            {
                if (afterCom != ".vn")
                {
                    return false;
                }
            }
            string specialUnvalidCharacter = " :,.;\"'/[]{}()<>";
            foreach (var c in specialUnvalidCharacter)
            {
                if (localName.Contains(c))
                {
                    return false;
                }
            }
            return true;
        }

    }
}
