using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Data.Common;
using System.Data.Odbc;

namespace Windown_programming_17_1
{

    internal class StudentDAO : PersonDAO
    {
        DBconnection dBconnection = new DBconnection();


        public DataTable loadStudent()
        {
            dataClassName = "Student";
            string sqlStr = string.Format("SELECT *FROM {0}", dataClassName);
            return dBconnection.load(sqlStr);
        }

        //public DataTable refreshStudent()
        //{

        //    string sqlStr = string.Format("Select* from {0}", dataClassName);
        //    return dBconnection.refresh(sqlStr);

        //}

        //public void addStudent(Student newStudent)
        //{
        //    string sqlStr = string.Format("INSERT INTO {4}(Name , Address ,CMND,Birthdate) VALUES ('{0}', '{1}','{2}','{3}')",
        //     newStudent.getName(), newStudent.getAddress(), newStudent.getCMND(), newStudent.getBirthDate(), dataClassName);
        //    dBconnection.execute(sqlStr);
        //}
        //public void adjustStudent(Student changeStudent)
        //{
        //    string sqlStr = string.Format("UPDATE HocSinh SET Ten = '{0}', DiaChi = '{1}' WHERE CMND = '{2}'",
        //    changeStudent.getName(), changeStudent.getAddress(), changeStudent.getCMND());
        //    dBconnection.execute(sqlStr);

        //}
        //public void deleteStudent(Student deletedStudent)
        //{

        //    string sqlStr = string.Format("DELETE FROM HocSinh WHERE CMND = '{0}'", deletedStudent.getCMND());
        //    dBconnection.execute(sqlStr);
        //}
    }

}

