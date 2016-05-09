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
    public partial class DlgTransfer : Form
    {
        int accountNumFrom, accountNumTo;
        double transferAmount;
        double newAmount;
        User currentUser;
        List<int> accountNumList;
        InputValidate Validator;
        string transactionMsg;
        string receiptMsg;
        

        public DlgTransfer()
        {
            InitializeComponent();
            Validator = new InputValidate();
        }

        public DlgTransfer(User user, List <int> accountNumList): this()
        {
            this.currentUser = user;
            this.accountNumList = accountNumList;
        }

        public string getTransactionMsg() { return transactionMsg; }
        public int getAccountFrom() { return accountNumFrom; }
        public int getAccountTo() { return accountNumTo; }
        public double getTransferAmount() { return transferAmount; }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (inputValid() == true)
            {
                accountNumFrom = Convert.ToInt32(txtAcctNumFrom.Text);
                accountNumTo = Convert.ToInt32(txtAcctNumTo.Text);
                transferAmount = Convert.ToDouble(txtAmount.Text);

                if (Validator.isExistAcct(accountNumFrom, currentUser) == true
                    && Validator.isExistAcct(accountNumTo, currentUser) == true) // transfer between own accounts.
                {
                    newAmount = currentUser.getAmountGeneral(accountNumFrom) - transferAmount;
                    if (newAmount >= 0)
                    {
                        currentUser.setAmountGeneral(accountNumFrom, newAmount);
                        newAmount = currentUser.getAmountGeneral(accountNumTo) + transferAmount;
                        currentUser.setAmountGeneral(accountNumTo, newAmount);
                        finish();
                    }
                    else
                    {
                        MessageBox.Show("Insufficient balance", "Error");
                        txtAmount.Text = "";
                    }
                }
                else if (Validator.isExistAcct(accountNumFrom, currentUser) == true
                    && Validator.isExistAcctInList (accountNumTo,accountNumList) == true) // transfer to other's account
                {
                    newAmount = currentUser.getAmountGeneral(accountNumFrom) - transferAmount;
                    if (newAmount >= 0)
                    {
                        currentUser.setAmountGeneral(accountNumFrom, newAmount);
                        finish();
                    }
                    else { 
                        MessageBox.Show("Isufficient balance", "Error"); 
                        txtAmount.Text = "";
                    }
                }
                else
                {
                    txtAcctNumFrom.Text = "";
                    txtAcctNumTo.Text = "";
                    txtAmount.Text = "";
                }
            }
        }

        private void finish()
        {
            transactionMsg = Environment.NewLine + "Transaction: Transfer from account " + accountNumFrom
                      + " To account " + accountNumTo + ", Amount: " + transferAmount;
            receiptMsg =
                       transactionMsg + Environment.NewLine +
                       Environment.NewLine + "User Id: ".PadRight(8) + currentUser.userId.PadRight(8) +
                       Environment.NewLine + "Checking account (last 4): ".PadRight(30) +
                       currentUser.getLastDigits(currentUser.getCheckAcct(), 4).PadRight(12) +
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

        private bool inputValid()
        {
            if (Validator.isDecimal(txtAcctNumFrom, "From Account") == false
                || Validator.isDecimal(txtAcctNumTo, "To Account") == false
                || Validator.isGreaterNum(0, txtAmount, "Amount") == false)
                return false;
           
            else
                return true;
        }

       
    }
}
