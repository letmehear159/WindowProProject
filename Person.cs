using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windown_programming_17_1
{
    internal class Person
    {
        private string id;
        private string gender;
        private string name;
        private string address;
        private string cmnd;
        private DateTime birthDate;
        private string email;
        private string phone;
        public Person(string id, string gender, string name, string address, string cmnd, DateTime birthDate, string phone, string email)
        {
            this.id = id;
            this.gender = gender;
            this.name = name;
            this.address = address;
            this.cmnd = cmnd;
            this.birthDate = birthDate;
            this.email = email;
            this.phone = phone;
        }



        public DateTime getBirthDate()
        {
            return this.birthDate;
        }
        public string getName()
        {
            return this.name;
        }
        public string getAddress()
        {
            return this.address;
        }
        public string getCMND()
        {
            return this.cmnd;
        }
        public string getId()
        {
            return this.id;
        }
        public string getGender()
        {
            return this.gender;
        }

        public string getPhone()
        {
            return this.phone;
        }
        public string getEmail()
        {
            return this.email;
        }



    }
}
