using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windown_programming_17_1
{
    internal class Teacher : Person
    {
        public Teacher(string name, string address, string cmnd, DateTime birthDate, string phone, string email) : base(name, address, cmnd, birthDate, phone, email)
        {
        }
    }
}
