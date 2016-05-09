namespace Proj2_BigBuckBank
{
    partial class FrmUserMenu
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
            this.btnTest = new System.Windows.Forms.Button();
            this.rBtnDeposit = new System.Windows.Forms.RadioButton();
            this.rBtnWithdraw = new System.Windows.Forms.RadioButton();
            this.rBtnBalance = new System.Windows.Forms.RadioButton();
            this.rBtnTransfer = new System.Windows.Forms.RadioButton();
            this.rBtnExit = new System.Windows.Forms.RadioButton();
            this.gBoxMenu = new System.Windows.Forms.GroupBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gBoxMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTest
            // 
            this.btnTest.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnTest.Location = new System.Drawing.Point(415, 20);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(134, 42);
            this.btnTest.TabIndex = 0;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // rBtnDeposit
            // 
            this.rBtnDeposit.AutoSize = true;
            this.rBtnDeposit.Location = new System.Drawing.Point(120, 49);
            this.rBtnDeposit.Name = "rBtnDeposit";
            this.rBtnDeposit.Size = new System.Drawing.Size(170, 29);
            this.rBtnDeposit.TabIndex = 1;
            this.rBtnDeposit.TabStop = true;
            this.rBtnDeposit.Text = "Make a deposit";
            this.rBtnDeposit.UseVisualStyleBackColor = true;
            this.rBtnDeposit.CheckedChanged += new System.EventHandler(this.rBtnDeposit_CheckedChanged);
            // 
            // rBtnWithdraw
            // 
            this.rBtnWithdraw.AutoSize = true;
            this.rBtnWithdraw.Location = new System.Drawing.Point(120, 107);
            this.rBtnWithdraw.Name = "rBtnWithdraw";
            this.rBtnWithdraw.Size = new System.Drawing.Size(189, 29);
            this.rBtnWithdraw.TabIndex = 2;
            this.rBtnWithdraw.TabStop = true;
            this.rBtnWithdraw.Text = "Make a Withdraw";
            this.rBtnWithdraw.UseVisualStyleBackColor = true;
            this.rBtnWithdraw.CheckedChanged += new System.EventHandler(this.rBtnWithdraw_CheckedChanged);
            // 
            // rBtnBalance
            // 
            this.rBtnBalance.AutoSize = true;
            this.rBtnBalance.Location = new System.Drawing.Point(120, 163);
            this.rBtnBalance.Name = "rBtnBalance";
            this.rBtnBalance.Size = new System.Drawing.Size(170, 29);
            this.rBtnBalance.TabIndex = 3;
            this.rBtnBalance.TabStop = true;
            this.rBtnBalance.Text = "Check Balance";
            this.rBtnBalance.UseVisualStyleBackColor = true;
            this.rBtnBalance.CheckedChanged += new System.EventHandler(this.rBtnBalance_CheckedChanged);
            // 
            // rBtnTransfer
            // 
            this.rBtnTransfer.AutoSize = true;
            this.rBtnTransfer.Location = new System.Drawing.Point(121, 224);
            this.rBtnTransfer.Name = "rBtnTransfer";
            this.rBtnTransfer.Size = new System.Drawing.Size(170, 29);
            this.rBtnTransfer.TabIndex = 4;
            this.rBtnTransfer.TabStop = true;
            this.rBtnTransfer.Text = "Transfer Funds";
            this.rBtnTransfer.UseVisualStyleBackColor = true;
            this.rBtnTransfer.CheckedChanged += new System.EventHandler(this.rBtnTransfer_CheckedChanged);
            // 
            // rBtnExit
            // 
            this.rBtnExit.AutoSize = true;
            this.rBtnExit.Location = new System.Drawing.Point(121, 281);
            this.rBtnExit.Name = "rBtnExit";
            this.rBtnExit.Size = new System.Drawing.Size(69, 29);
            this.rBtnExit.TabIndex = 5;
            this.rBtnExit.TabStop = true;
            this.rBtnExit.Text = "Exit";
            this.rBtnExit.UseVisualStyleBackColor = true;
            // 
            // gBoxMenu
            // 
            this.gBoxMenu.Controls.Add(this.rBtnDeposit);
            this.gBoxMenu.Controls.Add(this.rBtnExit);
            this.gBoxMenu.Controls.Add(this.rBtnWithdraw);
            this.gBoxMenu.Controls.Add(this.rBtnTransfer);
            this.gBoxMenu.Controls.Add(this.rBtnBalance);
            this.gBoxMenu.Location = new System.Drawing.Point(135, 68);
            this.gBoxMenu.Name = "gBoxMenu";
            this.gBoxMenu.Size = new System.Drawing.Size(414, 347);
            this.gBoxMenu.TabIndex = 6;
            this.gBoxMenu.TabStop = false;
            this.gBoxMenu.Text = "Menu";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(354, 457);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(200, 42);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.Text = "Exit with Receipt";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(135, 457);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(200, 42);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel No Receipt";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // FrmUserMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 569);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.gBoxMenu);
            this.Controls.Add(this.btnTest);
            this.Name = "FrmUserMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Menu";
            this.gBoxMenu.ResumeLayout(false);
            this.gBoxMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.RadioButton rBtnDeposit;
        private System.Windows.Forms.RadioButton rBtnWithdraw;
        private System.Windows.Forms.RadioButton rBtnBalance;
        private System.Windows.Forms.RadioButton rBtnTransfer;
        private System.Windows.Forms.RadioButton rBtnExit;
        private System.Windows.Forms.GroupBox gBoxMenu;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnCancel;
    }
}