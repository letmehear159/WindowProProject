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
    public partial class TeacherForm : Form
    {
        SqlConnection conn = new
  SqlConnection(Properties.Settings.Default.connStr);
        TeacherDAO teacherDAO = new TeacherDAO();

        public TeacherForm()
        {
            InitializeComponent();
            ucInformation1.btnAdd.Click += btnThem_Click_1;
            ucInformation1.btnAdjust.Click += btnSua_Click_1;
            ucInformation1.btnDelete.Click += btnXoa_Click_1;
            ucInformation1.btnRefresh.Click += btnRefresh_Click_1;
            ucInformation1.gvInformation.CellClick += CellClick;
        }

        public void refreshGV()
        {
            ucInformation1.gvInformation.DataSource = teacherDAO.loadTeacher();
        }
        private void TeacherForm_Load(object sender, EventArgs e)
        {

            ucInformation1.gvInformation.DataSource = teacherDAO.loadTeacher();
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            string genderValue = UCInformation.getGenderFromRadio(ucInformation1);
            Teacher newTeacher = new Teacher(ucInformation1.tbID.Text, genderValue, ucInformation1.tbName.Text, ucInformation1.tbAddress.Text,
                ucInformation1.tbCMND.Text, ucInformation1.dtBirthDate.Value, ucInformation1.tbPhone.Text, ucInformation1.tbEmail.Text);
            teacherDAO.add(newTeacher);
            refreshGV();
        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            refreshGV();
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            string genderValue = UCInformation.getGenderFromRadio(ucInformation1);
            Teacher deleteTeacher = new Teacher(ucInformation1.tbID.Text, genderValue, ucInformation1.tbName.Text, ucInformation1.tbAddress.Text,
                ucInformation1.tbCMND.Text, ucInformation1.dtBirthDate.Value, ucInformation1.tbPhone.Text, ucInformation1.tbEmail.Text);
            teacherDAO.delete(deleteTeacher);
            refreshGV();
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            string genderValue = UCInformation.getGenderFromRadio(ucInformation1);
            Teacher changeTeacher = new Teacher(ucInformation1.tbID.Text, genderValue, ucInformation1.tbName.Text, ucInformation1.tbAddress.Text,
                ucInformation1.tbCMND.Text, ucInformation1.dtBirthDate.Value, ucInformation1.tbPhone.Text, ucInformation1.tbEmail.Text);
            teacherDAO.adjust(changeTeacher);
            refreshGV();
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
                    string gender = selectedRow.Cells["Gender"].Value.ToString();
                    if (gender.Equals("Nam"))
                    {
                        ucInformation1.rbNam.Checked = true;
                    }
                    else
                    {
                        ucInformation1.rbNu.Checked = true;
                    }
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
