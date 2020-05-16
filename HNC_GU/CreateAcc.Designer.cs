namespace Assesssment_2_BankSystem_AndreaPalombi
{
    partial class CreateAcc
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
            this.txt_AccountNo = new System.Windows.Forms.TextBox();
            this.txt_PinNo = new System.Windows.Forms.TextBox();
            this.txt_Balance = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CreateAcc_btn = new System.Windows.Forms.Button();
            this.close_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_AccountNo
            // 
            this.txt_AccountNo.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AccountNo.Location = new System.Drawing.Point(144, 22);
            this.txt_AccountNo.MaxLength = 6;
            this.txt_AccountNo.Name = "txt_AccountNo";
            this.txt_AccountNo.Size = new System.Drawing.Size(100, 28);
            this.txt_AccountNo.TabIndex = 1;
            // 
            // txt_PinNo
            // 
            this.txt_PinNo.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PinNo.Location = new System.Drawing.Point(144, 62);
            this.txt_PinNo.MaxLength = 4;
            this.txt_PinNo.Name = "txt_PinNo";
            this.txt_PinNo.PasswordChar = '*';
            this.txt_PinNo.Size = new System.Drawing.Size(100, 28);
            this.txt_PinNo.TabIndex = 2;
            // 
            // txt_Balance
            // 
            this.txt_Balance.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Balance.Location = new System.Drawing.Point(144, 102);
            this.txt_Balance.Name = "txt_Balance";
            this.txt_Balance.Size = new System.Drawing.Size(100, 28);
            this.txt_Balance.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Account No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pin No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Balance";
            // 
            // CreateAcc_btn
            // 
            this.CreateAcc_btn.BackColor = System.Drawing.Color.Honeydew;
            this.CreateAcc_btn.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.CreateAcc_btn.Location = new System.Drawing.Point(144, 155);
            this.CreateAcc_btn.Name = "CreateAcc_btn";
            this.CreateAcc_btn.Size = new System.Drawing.Size(100, 43);
            this.CreateAcc_btn.TabIndex = 7;
            this.CreateAcc_btn.Text = "Create";
            this.CreateAcc_btn.UseVisualStyleBackColor = false;
            this.CreateAcc_btn.Click += new System.EventHandler(this.CreateAcc_btn_Click);
            // 
            // close_btn
            // 
            this.close_btn.BackColor = System.Drawing.Color.Honeydew;
            this.close_btn.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.close_btn.Location = new System.Drawing.Point(29, 155);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(100, 43);
            this.close_btn.TabIndex = 8;
            this.close_btn.Text = "Back";
            this.close_btn.UseVisualStyleBackColor = false;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // CreateAcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.CreateAcc_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Balance);
            this.Controls.Add(this.txt_PinNo);
            this.Controls.Add(this.txt_AccountNo);
            this.Name = "CreateAcc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Account";
            this.Load += new System.EventHandler(this.CreateAcc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_AccountNo;
        private System.Windows.Forms.TextBox txt_PinNo;
        private System.Windows.Forms.TextBox txt_Balance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CreateAcc_btn;
        private System.Windows.Forms.Button close_btn;
    }
}

