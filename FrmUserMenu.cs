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
    public partial class FrmUserMenu : Form
    {
        FrmLogin frmLogin;
        User currentUser;

        public FrmUserMenu()
        {
            InitializeComponent();
        }

        public FrmUserMenu(FrmLogin frmLogin, User currentUser):this()
        {
            this.frmLogin = frmLogin; // ny reference??? refer to frmlogin
            this.currentUser = currentUser; //refer to 
    
        }

        //public void setUser(User user){ this.user = user;}

        private void btnTest_Click(object sender, EventArgs e)
        {
            currentUser.setCheckAmount(800);
        }

        private void rBtnDeposit_CheckedChanged(object sender, EventArgs e)
        {
            DlgDeposit dlgDeposit = new DlgDeposit(this.currentUser);
            DialogResult selectButton = dlgDeposit.ShowDialog();

            
        } 


    }
}
