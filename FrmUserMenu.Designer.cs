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
            this.SuspendLayout();
            // 
            // btnTest
            // 
            this.btnTest.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnTest.Location = new System.Drawing.Point(293, 442);
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
            this.rBtnDeposit.Location = new System.Drawing.Point(257, 120);
            this.rBtnDeposit.Name = "rBtnDeposit";
            this.rBtnDeposit.Size = new System.Drawing.Size(170, 29);
            this.rBtnDeposit.TabIndex = 1;
            this.rBtnDeposit.TabStop = true;
            this.rBtnDeposit.Text = "Make a deposit";
            this.rBtnDeposit.UseVisualStyleBackColor = true;
            // 
            // rBtnWithdraw
            // 
            this.rBtnWithdraw.AutoSize = true;
            this.rBtnWithdraw.Location = new System.Drawing.Point(257, 170);
            this.rBtnWithdraw.Name = "rBtnWithdraw";
            this.rBtnWithdraw.Size = new System.Drawing.Size(189, 29);
            this.rBtnWithdraw.TabIndex = 2;
            this.rBtnWithdraw.TabStop = true;
            this.rBtnWithdraw.Text = "Make a Withdraw";
            this.rBtnWithdraw.UseVisualStyleBackColor = true;
            // 
            // rBtnBalance
            // 
            this.rBtnBalance.AutoSize = true;
            this.rBtnBalance.Location = new System.Drawing.Point(257, 225);
            this.rBtnBalance.Name = "rBtnBalance";
            this.rBtnBalance.Size = new System.Drawing.Size(170, 29);
            this.rBtnBalance.TabIndex = 3;
            this.rBtnBalance.TabStop = true;
            this.rBtnBalance.Text = "Check Balance";
            this.rBtnBalance.UseVisualStyleBackColor = true;
            // 
            // rBtnTransfer
            // 
            this.rBtnTransfer.AutoSize = true;
            this.rBtnTransfer.Location = new System.Drawing.Point(257, 277);
            this.rBtnTransfer.Name = "rBtnTransfer";
            this.rBtnTransfer.Size = new System.Drawing.Size(170, 29);
            this.rBtnTransfer.TabIndex = 4;
            this.rBtnTransfer.TabStop = true;
            this.rBtnTransfer.Text = "Transfer Funds";
            this.rBtnTransfer.UseVisualStyleBackColor = true;
            // 
            // rBtnExit
            // 
            this.rBtnExit.AutoSize = true;
            this.rBtnExit.Location = new System.Drawing.Point(257, 331);
            this.rBtnExit.Name = "rBtnExit";
            this.rBtnExit.Size = new System.Drawing.Size(69, 29);
            this.rBtnExit.TabIndex = 5;
            this.rBtnExit.TabStop = true;
            this.rBtnExit.Text = "Exit";
            this.rBtnExit.UseVisualStyleBackColor = true;
            // 
            // FrmUserMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 569);
            this.ControlBox = false;
            this.Controls.Add(this.rBtnExit);
            this.Controls.Add(this.rBtnTransfer);
            this.Controls.Add(this.rBtnBalance);
            this.Controls.Add(this.rBtnWithdraw);
            this.Controls.Add(this.rBtnDeposit);
            this.Controls.Add(this.btnTest);
            this.Name = "FrmUserMenu";
            this.Text = "User Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.RadioButton rBtnDeposit;
        private System.Windows.Forms.RadioButton rBtnWithdraw;
        private System.Windows.Forms.RadioButton rBtnBalance;
        private System.Windows.Forms.RadioButton rBtnTransfer;
        private System.Windows.Forms.RadioButton rBtnExit;
    }
}