using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windown_programming_17_1
{
    internal class Student : Person
    {
        public Student(string name, string address, string cmnd, DateTime birthDate, string phone, string email) : base(name, address, cmnd, birthDate, phone, email)
        {
        }
    }

}

