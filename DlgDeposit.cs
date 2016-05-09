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
        string transactionMsg;
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

        public string getTransactionMsg() { return transactionMsg; }

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
                    transactionMsg = Environment.NewLine + "Transaction: Deposit to account " + accountNum + ", Amount: " + amount;
                    receiptMsg =
                        transactionMsg + Environment.NewLine +
                        Environment.NewLine + "User Id: ".PadRight(8) + currentUser.userId.PadRight(8) +
                        Environment.NewLine + "Checking account (last 4): ".PadRight(30) + 
                        currentUser.getLastDigits( currentUser.getCheckAcct(),4).PadRight(12) +
                        "balance: ".PadRight(10) + String.Format("{0:c2}", currentUser.getCheckAmount()).PadRight(12) +
                        Environment.NewLine + "Saving account (last 4):   ".PadRight(30) +
                        currentUser.getLastDigits(currentUser.getSaveAcct(), 4).PadRight(12) +
                        "balance: ".PadRight(10) + String.Format("{0:c2}", currentUser.getSaveAmount()).PadRight(12);

                    FrmReceipt frmReceipt = new FrmReceipt(receiptMsg);
                    DialogResult selectedButton = frmReceipt.ShowDialog();
                    if (selectedButton == DialogResult.OK)
                    {
                        frmReceipt.Close();
                    }

                    this.DialogResult = DialogResult.OK; 
                }
                else
                {
                    txtAcctNum.Text = "";
                    txtAmount.Text = "";
                }
            }

        }

        private bool inputValid()
        {
            if (Validator.isDecimal(txtAcctNum, "Account Number") == false
                || Validator.isGreaterNum(0, txtAmount, "Amount") == false)
            {
                txtAcctNum.Text = "";
                txtAmount.Text = "";
                return false;
            }
            // else if (Validator.isDecimal(txtAcctNum, "Account Number") == false 
            //|| Validator.isDecimal(txtAmount, "Amount") == false)
            //return false;
            else
                return true;
        }


       
    }

}
