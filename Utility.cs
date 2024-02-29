using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windown_programming_17_1
{
    internal class Utility
    {
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
            if (phoneNum[0] != '0' || phoneNum.Substring(0, 2) != "84")
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
    }
}
