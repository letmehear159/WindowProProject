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

            if (!Utility.checkValidInformation(newPerson))
            {
                return;
            }
            string sqlStr = string.Format("INSERT INTO {4}(Name,Address,CMND,Birthdate,Phone, Email,id,gender) VALUES ('{0}', '{1}','{2}','{3}','{5}','{6}','{7}','{8}')",
            newPerson.getName(), newPerson.getAddress(), newPerson.getCMND(), newPerson.getBirthDate(), dataClassName, newPerson.getPhone(), newPerson.getEmail(), newPerson.getId(), newPerson.getGender());
            dBconnection.execute(sqlStr);


        }
        public void adjust(Person changePerson)
        {
            if (!Utility.checkValidInformation(changePerson))
            {
                return;
            }
            string sqlStr = string.Format("UPDATE {3} SET Name = '{0}', Address = '{1}', Birthdate='{4}'" +
                    ", Phone='{5}', Email='{6}',Id='{7}',gender='{8}' WHERE CMND = '{2}'",
                changePerson.getName(), changePerson.getAddress(), changePerson.getCMND(), dataClassName, changePerson.getBirthDate()
                , changePerson.getPhone(), changePerson.getEmail(), changePerson.getId(), changePerson.getGender());

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
