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

    public partial class FrmReceipt : Form
    {
        public FrmReceipt()
        {
            InitializeComponent();
        }

        public FrmReceipt(string message) :this()
        {
            txtContent.Text = message;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            
        }
    }
}
