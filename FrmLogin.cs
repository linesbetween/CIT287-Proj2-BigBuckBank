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
    public partial class FrmLogin : Form
    {
        int numOfTrial;
        AdminAcct adminAcct;
        public List<User> userList; // List of users
        IEnumerable<User> currentUserQuery;
        User currentUser;
        List<int> accountNumList;
        DataToAdmin dataToAdmin;

        public FrmLogin()
        {
            InitializeComponent();

            numOfTrial = 0;

            adminAcct = new AdminAcct("Admin123", "0000");

            //initialize user datas
            User user1 = new User("Alice123", "1111", 10000001, 1000, 20000001, 1000);
            User user2 = new User("Bob12345", "2222", 10000002, 2000, 20000002, 2000);
            User user3 = new User("Cathy123", "3333", 10000003, 3000, 20000003, 3000);
            User user4 = new User("Doe12345", "4444", 10000004, 3000, 20000004, 4000);

            userList = new List<User>();
            userList.Add(user1);
            userList.Add(user2);
            userList.Add(user3);
            userList.Add(user4);

            accountNumList = new List<int>();
            for (int i = 0; i < userList.Count; i++)
            {
                accountNumList.Add(userList[i].getCheckAcct());
                accountNumList.Add(userList[i].getSaveAcct());
            }

                for (int i = 0; i < userList.Count; i++)
                {
                    txtTest.AppendText(userList[i].toString());
                }
        }

        private void btnUserLogin_Click(object sender, EventArgs e)
        {
            string userId = txtUserId.Text;
            string userPsw = txtUserPsw.Text;

            if (checkUser(userId, userPsw) == false)
            {
                ++numOfTrial;
                MessageBox.Show("Wrong userId or password", "Error");
                clearDisplay();
            }
            else
            {

                //TODO search in userList and assign to currentUSer
                currentUserQuery = from user in userList
                                   where user.getUserId() == userId
                                   select user;
                foreach (User user in currentUserQuery) // TODO only one user in query, other method than foreach???
                    currentUser = user;

                //TODO open new dialog
                FrmUserMenu userMenu = new FrmUserMenu(this, currentUser, accountNumList, userList);
                this.Visible = false;

                //passDataToUserMenu(userMenu, userList[1]);
                DialogResult selectedButton =  userMenu.ShowDialog();
                if (selectedButton == DialogResult.Yes || selectedButton == DialogResult.OK
                    || selectedButton == DialogResult.Cancel) // when userMenu returns, refresh test display
                {
                    this.Visible = true;
                    this.clearDisplay();

                    txtTest.Clear();
                    for (int i = 0; i < userList.Count; i++)
                    {
                        txtTest.AppendText(userList[i].toString());
                    }
                }
            }

            if (numOfTrial == 3)
            {
                MessageBox.Show("PLEASE SEE A BANK OFFICER - NO FURTHER LOGIN ALLOWED", "Error");
                txtUserId.Enabled = false;
                txtUserPsw.Enabled = false;
                btnUserLogin.Enabled = false;
            }
        }

        bool checkUser(string userId, string userPsw)
        {
            for (int i = 0; i < userList.Count; ++i)
            {
                if (userId == userList[i].getUserId())
                {
                    if (userPsw == userList[i].getpassWord())
                        return true;
                    else
                        return false;
                }
            }

            return false;
        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            string adminId = txtAdminId.Text;
            string adminPsw = txtAdminPsw.Text;

            if (checkAdmin(adminId, adminPsw) == true)
            {
                clearDisplay();
                FrmAdmin dlgAdmin = new FrmAdmin();
                dataToAdmin = new DataToAdmin(numOfTrial);
                passDatatoAdmin(dlgAdmin, ref dataToAdmin);
                DialogResult selectedButton = dlgAdmin.ShowDialog();
                this.Visible = false;

                if (selectedButton == DialogResult.OK) // if Clear or Exit was clicked
                {
                    numOfTrial = 0;
                    txtNumOfTrial.Text = numOfTrial.ToString();
                    txtUserId.Enabled = true;
                    txtUserPsw.Enabled = true;
                    btnUserLogin.Enabled = true;
                    this.Visible = true;
                    dlgAdmin.Close();
                }

            }
            else
            {
                clearDisplay();
                MessageBox.Show("Id or Password wrong", "Error");
            }

        }

        bool checkAdmin(string adminId, string adminPsw)
        {
            if (adminId != adminAcct.getId())
            {
                return false;
            }
            else if (adminPsw != adminAcct.getPsw())
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        void clearDisplay()
        {
            txtUserId.Text = "";
            txtUserPsw.Text = "";
            txtAdminId.Text = "";
            txtAdminPsw.Text = "";
        }

        /*
        void passDataToUserMenu(FrmUserMenu dlg, User data)
        {
            dlg.setUser(data);
        }
        */
        void passDatatoAdmin(FrmAdmin dlg, ref DataToAdmin data)
        {
            dlg.setAdminData(data);
        }

      

    }


// /////////////////////class for Admin data

    public class AdminAcct
    {
        string adminId;
        string adminPsw;

        public AdminAcct(string id, string psw)
        {
            this.adminId = id;
            this.adminPsw = psw;
        }

        public string getId() { return adminId; }
        public string getPsw() { return adminPsw; }

        public string toString(){
            return adminId.PadRight(12) + adminPsw.PadRight(8) + "\n";
        }
    }


    public class DataToAdmin
    {
        int numOfTrials;

        public DataToAdmin(int num) { numOfTrials = num; }

        public int getNumOfTrials() { return numOfTrials; }
        public void setNumOfTrials(int num) { numOfTrials = num; }

    }
   
}
