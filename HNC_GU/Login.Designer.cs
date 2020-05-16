namespace Assesssment_2_BankSystem_AndreaPalombi
{
    partial class Login
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPin = new System.Windows.Forms.TextBox();
            this.tbAccount = new System.Windows.Forms.TextBox();
            this.Login_btn = new System.Windows.Forms.Button();
            this.balance_label = new System.Windows.Forms.Label();
            this.balanceDisplay_lbl = new System.Windows.Forms.Label();
            this.back_CreateAcc_btn = new System.Windows.Forms.Button();
            this.withdraw_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(38, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Pin No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(38, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Account No";
            // 
            // tbPin
            // 
            this.tbPin.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.tbPin.Location = new System.Drawing.Point(144, 67);
            this.tbPin.MaxLength = 4;
            this.tbPin.Name = "tbPin";
            this.tbPin.PasswordChar = '*';
            this.tbPin.Size = new System.Drawing.Size(100, 28);
            this.tbPin.TabIndex = 7;
            // 
            // tbAccount
            // 
            this.tbAccount.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.tbAccount.Location = new System.Drawing.Point(144, 28);
            this.tbAccount.MaxLength = 6;
            this.tbAccount.Name = "tbAccount";
            this.tbAccount.Size = new System.Drawing.Size(100, 28);
            this.tbAccount.TabIndex = 6;
            // 
            // Login_btn
            // 
            this.Login_btn.BackColor = System.Drawing.Color.Honeydew;
            this.Login_btn.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.Login_btn.Location = new System.Drawing.Point(166, 162);
            this.Login_btn.Name = "Login_btn";
            this.Login_btn.Size = new System.Drawing.Size(100, 43);
            this.Login_btn.TabIndex = 10;
            this.Login_btn.Text = "Login";
            this.Login_btn.UseVisualStyleBackColor = false;
            this.Login_btn.Click += new System.EventHandler(this.Login_btn_Click);
            // 
            // balance_label
            // 
            this.balance_label.AutoSize = true;
            this.balance_label.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.balance_label.Location = new System.Drawing.Point(41, 111);
            this.balance_label.Name = "balance_label";
            this.balance_label.Size = new System.Drawing.Size(65, 21);
            this.balance_label.TabIndex = 11;
            this.balance_label.Text = "Balance";
            // 
            // balanceDisplay_lbl
            // 
            this.balanceDisplay_lbl.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.balanceDisplay_lbl.Location = new System.Drawing.Point(144, 109);
            this.balanceDisplay_lbl.Name = "balanceDisplay_lbl";
            this.balanceDisplay_lbl.Size = new System.Drawing.Size(100, 23);
            this.balanceDisplay_lbl.TabIndex = 12;
            this.balanceDisplay_lbl.Click += new System.EventHandler(this.balanceDisplay_lbl_Click);
            // 
            // back_CreateAcc_btn
            // 
            this.back_CreateAcc_btn.BackColor = System.Drawing.Color.Honeydew;
            this.back_CreateAcc_btn.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.back_CreateAcc_btn.Location = new System.Drawing.Point(96, 230);
            this.back_CreateAcc_btn.Name = "back_CreateAcc_btn";
            this.back_CreateAcc_btn.Size = new System.Drawing.Size(100, 43);
            this.back_CreateAcc_btn.TabIndex = 13;
            this.back_CreateAcc_btn.Text = "Back";
            this.back_CreateAcc_btn.UseVisualStyleBackColor = false;
            this.back_CreateAcc_btn.Click += new System.EventHandler(this.back_CreateAcc_btn_Click);
            // 
            // withdraw_btn
            // 
            this.withdraw_btn.BackColor = System.Drawing.Color.Honeydew;
            this.withdraw_btn.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.withdraw_btn.Location = new System.Drawing.Point(42, 162);
            this.withdraw_btn.Name = "withdraw_btn";
            this.withdraw_btn.Size = new System.Drawing.Size(100, 43);
            this.withdraw_btn.TabIndex = 14;
            this.withdraw_btn.Text = "Withdraw";
            this.withdraw_btn.UseVisualStyleBackColor = false;
            this.withdraw_btn.Click += new System.EventHandler(this.withdraw_btn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(282, 298);
            this.Controls.Add(this.withdraw_btn);
            this.Controls.Add(this.back_CreateAcc_btn);
            this.Controls.Add(this.balanceDisplay_lbl);
            this.Controls.Add(this.balance_label);
            this.Controls.Add(this.Login_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbPin);
            this.Controls.Add(this.tbAccount);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPin;
        private System.Windows.Forms.TextBox tbAccount;
        private System.Windows.Forms.Button Login_btn;
        private System.Windows.Forms.Label balance_label;
        private System.Windows.Forms.Label balanceDisplay_lbl;
        private System.Windows.Forms.Button back_CreateAcc_btn;
        private System.Windows.Forms.Button withdraw_btn;
    }
}