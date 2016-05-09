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
                MessageBox.Show("Account " + num + " doesn't belong to user " + user.userId , "Warning");
                return false;
            }

        }

        public bool isExistAcctInList(int num, List<int> list)
        {
            foreach (int account in list)
            {
                if (num == account)
                    return true;
            }
            MessageBox.Show("Account " + num + " doesn't exists.", "Error");
            return false;
        }

        public bool isGreaterNum(decimal num, TextBox txtBox, string name = "")
        {
            if (isDecimal(txtBox, name) == true)
            {
                if (Convert.ToDecimal(txtBox.Text) > num)
                    return true;
                else {
                    MessageBox.Show(name + " must be greater than " + String.Format("{0}", num), "Error");
                    return false; 
                }
            }
            else return false;
        }

        public bool isDecimal(TextBox txtBox, string name = "")
        {
            decimal number;

            if (checkFilled(txtBox, name) == true)
            {
                if (Decimal.TryParse(txtBox.Text, out number))
                    return true;
                else
                {
                    MessageBox.Show("Input must be numberic " + name, "Error");
                    return false;
                }
            }

            else return false;
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
