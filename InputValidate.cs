using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Proj2_BigBuckBank
{
    class InputValidate
    {
        public bool isExistAcct(int num, User user)
        {
            if (num == user.getCheckAcct() || num == user.getSaveAcct())
                return true;
            else
            {
                MessageBox.Show("Account doesn't exist", "Error");
                return false;
            }

        }


        public bool isDecimal(TextBox txtBox, string name = "")
        {
            decimal number;
            if (Decimal.TryParse(txtBox.Text, out number))
                return true;
            else
            {
                MessageBox.Show("Input must be numberic " + name, "Error");
                return false;
            }
        }

        public bool checkFilled(TextBox txtBox, string name = "")
        {
            if (txtBox.Text == "")
            {
                MessageBox.Show("All field must be filled: " + name, "Error");
                return false;
            }
            else return true;
        }
    }
}
