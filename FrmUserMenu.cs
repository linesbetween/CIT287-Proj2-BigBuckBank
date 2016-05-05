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
        User user;

        public FrmUserMenu()
        {
            InitializeComponent();
        }

        public FrmUserMenu(FrmLogin frmLogin, User currentUser):this()
        {
            this.frmLogin = frmLogin; // ny reference???
            user = currentUser;
    
        }

        //public void setUser(User user){ this.user = user;}

        private void btnTest_Click(object sender, EventArgs e)
        {
            user.setStartBalance(800);
        }

        private void rBtnDeposit_CheckedChanged(object sender, EventArgs e)
        {

        } 

    }
}
