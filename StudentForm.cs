using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace Windown_programming_17_1
{
    public partial class FUser : Form
    {
        SqlConnection conn = new
   SqlConnection(Properties.Settings.Default.connStr);

        public FUser()
        {
            InitializeComponent();

        }
        private void FUser_Load(object sender, EventArgs e)
        {
            StudentDAO studentDAO = new StudentDAO();
            gvHs.DataSource = studentDAO.loadStudent();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            StudentDAO studentDAO = new StudentDAO();
            Student deleteStudent = new Student(null, null, tbCMND.Text, dtNgaySinh.Value);
            studentDAO.deleteStudent(deleteStudent);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            StudentDAO studentDAO = new StudentDAO();
            Student newStudent = new Student(tbName.Text, tbDiaChi.Text, tbCMND.Text, dtNgaySinh.Value);
            studentDAO.addStudent(newStudent);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            StudentDAO studentDAO = new StudentDAO();
            Student newStudent = new Student(tbName.Text, tbDiaChi.Text, tbCMND.Text, dtNgaySinh.Value);
            studentDAO.adjustStudent(newStudent);
        }





        private void btnRefresh_Click(object sender, EventArgs e)
        {
            StudentDAO studentDAO = new StudentDAO();
            gvHs.DataSource = studentDAO.refreshStudent();
        }

        private void gvHs_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = gvHs.Rows[e.RowIndex];
                string tenHS = selectedRow.Cells["ten"].Value.ToString();
                tbName.Text = tenHS;
                tenHS = selectedRow.Cells["DiaCHi"].Value.ToString();
                tbDiaChi.Text = tenHS;
                tenHS = selectedRow.Cells["CMND"].Value.ToString();
                tbCMND.Text = tenHS;

            }
        }
    }
}
