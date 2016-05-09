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
        List<int> accountNumList;
        List<User> userList;
        string transactionsStr;
        int accountFrom, accountTo;
        double transferAmount;

        public FrmUserMenu()
        {
            InitializeComponent();
            transactionsStr = "";
        }

        public FrmUserMenu(FrmLogin frmLogin, User currentUser, List<int>  accountNumList , List <User> users):this()
        {
            this.frmLogin = frmLogin; // ny reference??? refer to frmlogin
            this.currentUser = currentUser; //refer to 
            this.accountNumList = accountNumList;
            this.userList = users;
        }

        //public void setUser(User user){ this.user = user;}

        private void btnTest_Click(object sender, EventArgs e)
        {
            currentUser.setCheckAmount(800);
        }

        private void rBtnDeposit_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnDeposit.Checked == true)
            {
                this.Visible = false;
                DlgDeposit dlgDeposit = new DlgDeposit(this.currentUser);
                DialogResult selectButton = dlgDeposit.ShowDialog();
                
                if (selectButton == DialogResult.OK || selectButton == DialogResult.Cancel)
                {
                    this.Visible = true;
                    transactionsStr += dlgDeposit.getTransactionMsg();
                    dlgDeposit.Close();
                }

                rBtnDeposit.Checked = false;
            }
        }

        private void rBtnWithdraw_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnWithdraw.Checked == true)
            {
                this.Visible = false;
                DlgWithdraw dlgWithdraw = new DlgWithdraw(this.currentUser);
                DialogResult selectButton = dlgWithdraw.ShowDialog();
                
                if (selectButton == DialogResult.OK || selectButton == DialogResult.Cancel)
                {
                    this.Visible = true;
                    transactionsStr += dlgWithdraw.getTransactionMsg();
                    dlgWithdraw.Close();
                }

                rBtnWithdraw.Checked = false;
            }
        }

        private void rBtnBalance_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnBalance.Checked == true)
            {
                this.Visible = false;
                DlgBalance dlgBalance = new DlgBalance(this.currentUser);
                DialogResult selectButton = dlgBalance.ShowDialog();

                if (selectButton == DialogResult.OK || selectButton == DialogResult.Cancel)
                {
                    this.Visible = true;
                    dlgBalance.Close();
                }

                rBtnBalance.Checked = false;
            }
        }

        private void rBtnTransfer_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnTransfer.Checked == true)
            {
                this.Visible = false;
                DlgTransfer dlgTransfer = new DlgTransfer(this.currentUser, accountNumList);
                DialogResult selectButton = dlgTransfer.ShowDialog();

                if (selectButton == DialogResult.OK || selectButton == DialogResult.Cancel)
                {
                    this.Visible = true;
                    transactionsStr += dlgTransfer.getTransactionMsg();
                    this.accountFrom = dlgTransfer.getAccountFrom();
                    this.accountTo = dlgTransfer.getAccountTo();
                    this.transferAmount = dlgTransfer.getTransferAmount();

                    foreach (User user in userList)
                    {
                        if (user.getCheckAcct() == accountTo)
                            user.setCheckAmount(user.getCheckAmount() + transferAmount);
                        else if (user.getSaveAcct() == accountTo)
                            user.setSaveAmount(user.getSaveAmount() + transferAmount);
                    }

                    dlgTransfer.Close();
                }

                rBtnTransfer.Checked = false;
            }
        } 


    }
}
