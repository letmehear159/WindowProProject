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
        public Student(string id, string gender, string name, string address, string cmnd, DateTime birthDate, string phone, string email) :
            base(id, gender, name, address, cmnd, birthDate, phone, email)
        {
        }
    }

}

