using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;

namespace Windown_programming_17_1
{
    internal class TeacherDAO : PersonDAO
    {
        DBconnection dbconnection = new DBconnection();

        public DataTable loadTeacher()
        {
            dataClassName = "teacher";
            string sqlStr = string.Format("SELECT *FROM {0}", dataClassName);
            return dbconnection.load(sqlStr);
        }

        //public DataTable refreshTeacher()
        //{

        //    string sqlStr = string.Format("Select* from Teacher");
        //    return dbconnection.refresh(sqlStr);

        //}

        //public void addTeacher(Teacher newStudent)
        //{
        //    string sqlStr = string.Format("INSERT INTO Teacher(Name , Address ,CMND,BirthDate) VALUES ('{0}', '{1}','{2}','{3}')",
        //    newStudent.getName(), newStudent.getAddress(), newStudent.getCMND(), newStudent.getBirthDate());
        //    dbconnection.execute(sqlStr);
        //}
        //public void adjustTeacher(Teacher changeTeacher)
        //{
        //    string sqlStr = string.Format("UPDATE Teacher SET Name = '{0}', Address = '{1}' WHERE CMND = '{2}'",
        //    changeTeacher.getName(), changeTeacher.getAddress(), changeTeacher.getCMND());
        //    dbconnection.execute(sqlStr);

        //}
        //public void deleteTeacher(Teacher deletedTeacher)
        //{

        //    string sqlStr = string.Format("DELETE FROM Teacher WHERE CMND = '{0}'", deletedTeacher.getCMND());
        //    dbconnection.execute(sqlStr);
        //}
    }
}
