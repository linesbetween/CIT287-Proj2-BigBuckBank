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
            this.txtAdminId = new System.Windows.Forms.TextBox();
            this.txtAdminPsw = new System.Windows.Forms.TextBox();
            this.btnUserLogin = new System.Windows.Forms.Button();
            this.btnAdminLogin = new System.Windows.Forms.Button();
            this.txtUserPsw = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "User ID (Case)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Admin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Admin PSW";
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(258, 70);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(205, 29);
            this.txtUserId.TabIndex = 4;
            // 
            // txtAdminId
            // 
            this.txtAdminId.Location = new System.Drawing.Point(258, 280);
            this.txtAdminId.Name = "txtAdminId";
            this.txtAdminId.Size = new System.Drawing.Size(205, 29);
            this.txtAdminId.TabIndex = 6;
            // 
            // txtAdminPsw
            // 
            this.txtAdminPsw.Location = new System.Drawing.Point(258, 345);
            this.txtAdminPsw.Name = "txtAdminPsw";
            this.txtAdminPsw.Size = new System.Drawing.Size(205, 29);
            this.txtAdminPsw.TabIndex = 7;
            // 
            // btnUserLogin
            // 
            this.btnUserLogin.Location = new System.Drawing.Point(305, 202);
            this.btnUserLogin.Name = "btnUserLogin";
            this.btnUserLogin.Size = new System.Drawing.Size(157, 40);
            this.btnUserLogin.TabIndex = 8;
            this.btnUserLogin.Text = "User Login";
            this.btnUserLogin.UseVisualStyleBackColor = true;
            this.btnUserLogin.Click += new System.EventHandler(this.btnUserLogin_Click);
            // 
            // btnAdminLogin
            // 
            this.btnAdminLogin.Location = new System.Drawing.Point(305, 408);
            this.btnAdminLogin.Name = "btnAdminLogin";
            this.btnAdminLogin.Size = new System.Drawing.Size(156, 37);
            this.btnAdminLogin.TabIndex = 9;
            this.btnAdminLogin.Text = "Admin Login";
            this.btnAdminLogin.UseVisualStyleBackColor = true;
            this.btnAdminLogin.Click += new System.EventHandler(this.btnAdminLogin_Click);
            // 
            // txtUserPsw
            // 
            this.txtUserPsw.Location = new System.Drawing.Point(258, 130);
            this.txtUserPsw.Name = "txtUserPsw";
            this.txtUserPsw.Size = new System.Drawing.Size(205, 29);
            this.txtUserPsw.TabIndex = 5;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 536);
            this.ControlBox = false;
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.TextBox txtAdminId;
        private System.Windows.Forms.TextBox txtAdminPsw;
        private System.Windows.Forms.Button btnUserLogin;
        private System.Windows.Forms.Button btnAdminLogin;
        private System.Windows.Forms.TextBox txtUserPsw;
    }
}

