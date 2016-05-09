using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj2_BigBuckBank
{
    // /////////////////////class for each User data
    public class Account
    {
        int accountNum;
        double amount;

        public Account()
        {
            accountNum = 0;
            amount = 0;
        }

        public Account(int num, double amount)
        {
            accountNum = num;
            this.amount = amount;
        }

        public int getAccountNum() { return accountNum; }
        public double getAmount() { return amount; }
        public void setAmount(double amount) { this.amount = amount; }
    }


    public class User
    {
        public string userId;
        string password;
        //int checkAcctNum ;
        //int saveAcctNum ;
        //double startBalance;
        Account saveAccount;
        Account checkAccount;

        /*
        public User(string userId, string password, int checkAcct, int saveAcct, double startBalance)
        {
            this.userId = userId;
            this.password = password;
            this.checkAcctNum = checkAcct;
            this.saveAcctNum = saveAcct;
            this.startBalance = startBalance;
        }
         * */

        public User(string userId, string password, int checkAcct, double checkBalance, int saveAcct, double saveBalance)
        {
            this.userId = userId;
            this.password = password;
            //this.checkAcctNum = checkAcct;
            //this.saveAcctNum = saveAcct;
            //this.startBalance = startBalance;
            saveAccount = new Account(checkAcct, checkBalance);
            checkAccount = new Account(saveAcct, saveBalance);
        }

        public string getUserId() { return userId; }
        public string getpassWord() { return password; }
        public int getCheckAcct() { return checkAccount.getAccountNum(); }
        public int getSaveAcct() { return saveAccount.getAccountNum(); }
        public double getCheckAmount() { return checkAccount.getAmount(); }
        public double getSaveAmount() { return saveAccount.getAmount(); }
        public double getAmountGeneral(int accountNum)
        {
            if (accountNum == getCheckAcct())
                return checkAccount.getAmount();
            else if (accountNum == getSaveAcct())
                return saveAccount.getAmount();
            else
            {
                MessageBox.Show("UserID: " + getUserId() + " doesn't have this account " + String.Format("{0}",accountNum), "Error");
                return 0;
            }
        }
        public void setCheckAmount(double amount) { checkAccount.setAmount(amount); }
        public void setSaveAmount(double amount) { saveAccount.setAmount(amount); }
        public void setAmountGeneral(int accountNum, double amount)
        {
            if (accountNum == getCheckAcct())
                setCheckAmount(amount);
            else if (accountNum == getSaveAcct())
                setSaveAmount(amount);
            else
                MessageBox.Show("UserID: " + getUserId() + " doesn't have this account " + String.Format("{0}", accountNum), "Error");
        }

        public string toString()
        {
            return userId.PadRight(12) + (String.Format("{0}", password)).PadRight(8)
                + (String.Format("{0}", checkAccount.getAccountNum())).PadRight(12)
                + (String.Format("{0:c}", checkAccount.getAmount())).PadRight(12)
                + (String.Format("{0}", saveAccount.getAccountNum())).PadRight(12)
                + (String.Format("{0:c}", saveAccount.getAmount())).PadRight(8) + "\n";
        }

        public string getLastDigits (int num, int numDigits){
            string lastDigits = "";

            for (int i = 0; i < numDigits; ++i)
            {
                lastDigits = String.Format("{0}" ,num % 10) + lastDigits ;
                num /= 10;
            }

                return lastDigits;
        }
    }

   
}
