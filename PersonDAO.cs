using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windown_programming_17_1
{
    internal class PersonDAO
    {
        DBconnection dBconnection = new DBconnection();
        protected string dataClassName = "";

        public DataTable refresh()
        {
            string sqlStr = string.Format("Select* from {0}", dataClassName);
            return dBconnection.refresh(sqlStr);
        }

        public void add(Person newPerson)
        {


            if (Utility.isValidValuePassed(newPerson) != false)
            {
                if (!Utility.checkPhoneValid(newPerson.getPhone()))
                {
                    MessageBox.Show("Error phone number");
                    return;
                }
                string sqlStr = string.Format("INSERT INTO {4}(Name , Address ,CMND,Birthdate,Phone, Email) VALUES ('{0}', '{1}','{2}','{3}','{5}','{6}')",
                newPerson.getName(), newPerson.getAddress(), newPerson.getCMND(), newPerson.getBirthDate(), dataClassName, newPerson.getPhone(), newPerson.getEmail());
                dBconnection.execute(sqlStr);
            }
            else
            {
                MessageBox.Show("Invaild information, Please fill emtpy form!");
            }


        }
        public void adjust(Person changePerson)
        {
            if (Utility.isValidValuePassed(changePerson) != false)
            {
                if (!Utility.checkPhoneValid(changePerson.getPhone()))
                {
                    MessageBox.Show("Error phone number");
                    return;
                }
                string sqlStr = string.Format("UPDATE {3} SET Name = '{0}', Address = '{1}', Birthdate='{4}'" +
                    ", Phone='{5}', Email='{6}' WHERE CMND = '{2}'",
                changePerson.getName(), changePerson.getAddress(), changePerson.getCMND(), dataClassName, changePerson.getBirthDate()
                , changePerson.getPhone(), changePerson.getEmail());
                dBconnection.execute(sqlStr);
            }
            else
            {
                MessageBox.Show("Invaild information, Please fill emtpy form!");
            }

        }
        public void delete(Person deletedPerson)
        {
            if (string.IsNullOrEmpty(deletedPerson.getCMND()))
            {
                MessageBox.Show("CMND's empty, cannot find appropriate person");
            }
            else
            {
                string sqlStr = string.Format("DELETE FROM {1} WHERE CMND = '{0}'", deletedPerson.getCMND(), dataClassName);
                dBconnection.execute(sqlStr);
            }

        }
    }
}
