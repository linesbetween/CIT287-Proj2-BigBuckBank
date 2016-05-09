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
    public partial class DlgBalance : Form
    {
        int accountNum;
        User currentUser;
        InputValidate Validator;

        public DlgBalance()
        {
            InitializeComponent();
            Validator = new InputValidate();
        }

        public DlgBalance(User user)
            : this()
        {
            this.currentUser = user;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (inputValid() == true)
            {
                accountNum = Convert.ToInt32(txtAcctNum.Text);

                if (Validator.isExistAcct(accountNum, currentUser) == true)
                {
                    txtAmount.Text = String.Format("{0:c2}",currentUser.getAmountGeneral(accountNum));
                   
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
            if (Validator.isDecimal(txtAcctNum, "Account Number") == false)
                return false;
            else
                return true;
        }

        private void txtAcctNum_TextChanged(object sender, EventArgs e)
        {
            txtAmount.Text = "";
        }

        
    }
}
