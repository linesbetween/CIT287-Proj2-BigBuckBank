using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj2_BigBuckBank
{
    public partial class FrmAdmin : Form
    {
        DataToAdmin adminData;

        public FrmAdmin()
        {
            InitializeComponent();
        }

        public void setAdminData(DataToAdmin data) { adminData = data;  }

        private void btnClear_Click(object sender, EventArgs e)
        {
            adminData.setNumOfTrials(0);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            
        }
    }
}
