using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windown_programming_17_1
{
    public partial class StudentFormFinal : Form
    {
        SqlConnection conn = new
 SqlConnection(Properties.Settings.Default.connStr);
        StudentDAO studentDAO = new StudentDAO();

        public StudentFormFinal()
        {
            InitializeComponent();
            ucInformation2.btnAdd.Click += btnThem_Click;
            ucInformation2.btnAdjust.Click += btnSua_Click;
            ucInformation2.btnDelete.Click += btnXoa_Click;
            ucInformation2.btnRefresh.Click += btnRefresh_Click;
            ucInformation2.gvInformation.CellClick += CellClick;

            //AddButtonClick += btnThem_Click;
        }
        public void refreshGV()
        {
            ucInformation2.gvInformation.DataSource = studentDAO.loadStudent();
        }
        public void btnThem_Click(object sender, EventArgs e)
        {

            Student newStudent = new Student(ucInformation2.tbName.Text, ucInformation2.tbAddress.Text,
                ucInformation2.tbCMND.Text, ucInformation2.dtBirthDate.Value, ucInformation2.tbPhone.Text, ucInformation2.tbEmail.Text);
            studentDAO.add(newStudent);
            refreshGV();
        }

        private void StudentFormFinal_Load(object sender, EventArgs e)
        {
            ucInformation2.gvInformation.DataSource = studentDAO.loadStudent();
        }

        public void btnRefresh_Click(object sender, EventArgs e)
        {
            refreshGV();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Student deleteStudent = new Student(ucInformation2.tbName.Text, ucInformation2.tbAddress.Text,
                ucInformation2.tbCMND.Text, ucInformation2.dtBirthDate.Value, ucInformation2.tbPhone.Text, ucInformation2.tbEmail.Text);
            studentDAO.delete(deleteStudent);
            refreshGV();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Student changeStudent = new Student(ucInformation2.tbName.Text, ucInformation2.tbAddress.Text,
                ucInformation2.tbCMND.Text, ucInformation2.dtBirthDate.Value, ucInformation2.tbPhone.Text, ucInformation2.tbEmail.Text);
            studentDAO.adjust(changeStudent);
            refreshGV();
        }

        private void gvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow selectedRow = ucInformation1.gvInformation.Rows[e.RowIndex];
                    ucInformation1.tbName.Text = selectedRow.Cells["Name"].Value.ToString();
                    ucInformation1.tbAddress.Text = selectedRow.Cells["Address"].Value.ToString();
                    ucInformation1.tbCMND.Text = selectedRow.Cells["CMND"].Value.ToString();
                    ucInformation1.tbPhone.Text = selectedRow.Cells["Phone"].Value.ToString();
                    ucInformation1.tbEmail.Text = selectedRow.Cells["Phone"].Value.ToString();
                    DateTime dateTimeValue;
                    if (DateTime.TryParse(selectedRow.Cells["BirthDate"].Value.ToString(), out dateTimeValue))
                    {
                        // Đặt giá trị vào DateTimePicker
                        ucInformation1.dtBirthDate.Value = dateTimeValue;
                    }

                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);

            }

        }

    }
}
