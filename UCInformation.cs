using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windown_programming_17_1
{
    public partial class UCInformation : UserControl
    {

        public UCInformation()
        {
            InitializeComponent();

        }

        private void gvInformation_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UCInformation_Load(object sender, EventArgs e)
        {

        }

        private void dtBirthDate_ValueChanged(object sender, EventArgs e)
        {

        }
        public static string getGenderFromRadio(UCInformation uc)
        {
            string genderValue = "";
            if (uc.rbNu.Checked)
            {
                genderValue = uc.rbNu.Text;
            }
            else if (uc.rbNam.Checked)
            {
                genderValue = uc.rbNam.Text;
            }
            return genderValue;
        }
    }
}
