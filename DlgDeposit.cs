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
    public partial class DlgDeposit : Form
    {
        int accountNum;
        double amount;
        double newAmount;
        User currentUser;
        InputValidate Validator;
        string receiptMsg;

        public DlgDeposit()
        {
            InitializeComponent();
            Validator = new InputValidate();
        }

        public DlgDeposit(User user) : this()
        {
            this.currentUser = user;
        }


        private void btnOk_Click(object sender, EventArgs e)
        {
            if (inputValid() == true)
            {
                accountNum = Convert.ToInt32(txtAcctNum.Text);
                amount = Convert.ToDouble(txtAmount.Text);

                if (Validator.isExistAcct(accountNum, currentUser) == true)
                {
                    newAmount = currentUser.getAmountGeneral(accountNum) + amount; //update amount
                    currentUser.setAmountGeneral(accountNum, newAmount); //change current user

                    //print temporary receipt
                    receiptMsg =
                        "\n User Id: ".PadRight(8) + currentUser.userId.PadRight(8) +
                        "\n Checking account: ".PadRight(20) + String.Format("{0}", currentUser.getCheckAcct() % 10000).PadRight(12) +
                            ", balance: ".PadRight(10) + String.Format("{0,c}", currentUser.getCheckAmount()).PadRight(12) +
                        "\n Saving account: ".PadRight(20) + String.Format("{0}", currentUser.getSaveAcct() % 10000).PadRight(12) +
                            ", balance: ".PadRight(10) + String.Format("{0,c}", currentUser.getSaveAmount()).PadRight(12);

 

                    this.DialogResult = DialogResult.OK; //close dialog window
                }
            }
            
        }

        private bool inputValid()
        {
            if (Validator.checkFilled(txtAcctNum, "Account Number") == false 
                || Validator.checkFilled(txtAmount, "Amount") == false)
                return false;
            else if (Validator.isDecimal(txtAcctNum, "Account Number") == false 
                || Validator.isDecimal(txtAmount, "Amount") == false)
                return false;
            else
                return true;
        }


       
    }

}
