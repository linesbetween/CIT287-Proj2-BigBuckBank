namespace Proj2_BigBuckBank
{
    partial class FrmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.txtUserPsw = new System.Windows.Forms.TextBox();
            this.txtAdminId = new System.Windows.Forms.TextBox();
            this.txtAdminPsw = new System.Windows.Forms.TextBox();
            this.btnUserLogin = new System.Windows.Forms.Button();
            this.btnAdminLogin = new System.Windows.Forms.Button();
            this.txtTest = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumOfTrial = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "User ID (Case)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(181, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Admin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(181, 365);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Admin PSW";
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(347, 73);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(223, 31);
            this.txtUserId.TabIndex = 4;
            // 
            // txtUserPsw
            // 
            this.txtUserPsw.Location = new System.Drawing.Point(347, 135);
            this.txtUserPsw.Name = "txtUserPsw";
            this.txtUserPsw.Size = new System.Drawing.Size(223, 31);
            this.txtUserPsw.TabIndex = 5;
            // 
            // txtAdminId
            // 
            this.txtAdminId.Location = new System.Drawing.Point(347, 292);
            this.txtAdminId.Name = "txtAdminId";
            this.txtAdminId.Size = new System.Drawing.Size(223, 31);
            this.txtAdminId.TabIndex = 6;
            // 
            // txtAdminPsw
            // 
            this.txtAdminPsw.Location = new System.Drawing.Point(347, 359);
            this.txtAdminPsw.Name = "txtAdminPsw";
            this.txtAdminPsw.Size = new System.Drawing.Size(223, 31);
            this.txtAdminPsw.TabIndex = 7;
            // 
            // btnUserLogin
            // 
            this.btnUserLogin.Location = new System.Drawing.Point(398, 210);
            this.btnUserLogin.Name = "btnUserLogin";
            this.btnUserLogin.Size = new System.Drawing.Size(171, 42);
            this.btnUserLogin.TabIndex = 8;
            this.btnUserLogin.Text = "User Login";
            this.btnUserLogin.UseVisualStyleBackColor = true;
            this.btnUserLogin.Click += new System.EventHandler(this.btnUserLogin_Click);
            // 
            // btnAdminLogin
            // 
            this.btnAdminLogin.Location = new System.Drawing.Point(398, 425);
            this.btnAdminLogin.Name = "btnAdminLogin";
            this.btnAdminLogin.Size = new System.Drawing.Size(170, 39);
            this.btnAdminLogin.TabIndex = 9;
            this.btnAdminLogin.Text = "Admin Login";
            this.btnAdminLogin.UseVisualStyleBackColor = true;
            this.btnAdminLogin.Click += new System.EventHandler(this.btnAdminLogin_Click);
            // 
            // txtTest
            // 
            this.txtTest.Location = new System.Drawing.Point(668, 73);
            this.txtTest.Multiline = true;
            this.txtTest.Name = "txtTest";
            this.txtTest.ReadOnly = true;
            this.txtTest.Size = new System.Drawing.Size(619, 179);
            this.txtTest.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(668, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Trial";
            // 
            // txtNumOfTrial
            // 
            this.txtNumOfTrial.Location = new System.Drawing.Point(775, 297);
            this.txtNumOfTrial.Name = "txtNumOfTrial";
            this.txtNumOfTrial.Size = new System.Drawing.Size(109, 31);
            this.txtNumOfTrial.TabIndex = 12;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1351, 531);
            this.ControlBox = false;
            this.Controls.Add(this.txtNumOfTrial);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTest);
            this.Controls.Add(this.btnAdminLogin);
            this.Controls.Add(this.btnUserLogin);
            this.Controls.Add(this.txtAdminPsw);
            this.Controls.Add(this.txtAdminId);
            this.Controls.Add(this.txtUserPsw);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmLogin";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.TextBox txtUserPsw;
        private System.Windows.Forms.TextBox txtAdminId;
        private System.Windows.Forms.TextBox txtAdminPsw;
        private System.Windows.Forms.Button btnUserLogin;
        private System.Windows.Forms.Button btnAdminLogin;
        private System.Windows.Forms.TextBox txtTest;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNumOfTrial;
    }
}

