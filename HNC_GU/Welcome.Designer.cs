namespace Assesssment_2_BankSystem_AndreaPalombi
{
    partial class Welcome
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
            this.labelWelcome1 = new System.Windows.Forms.Label();
            this.Create_btn = new System.Windows.Forms.Button();
            this.Login_btn = new System.Windows.Forms.Button();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.labelWelcome2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelWelcome1
            // 
            this.labelWelcome1.AutoSize = true;
            this.labelWelcome1.BackColor = System.Drawing.Color.Transparent;
            this.labelWelcome1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome1.Location = new System.Drawing.Point(11, 6);
            this.labelWelcome1.Name = "labelWelcome1";
            this.labelWelcome1.Size = new System.Drawing.Size(130, 24);
            this.labelWelcome1.TabIndex = 0;
            this.labelWelcome1.Text = "WELCOME ON";
            // 
            // Create_btn
            // 
            this.Create_btn.BackColor = System.Drawing.Color.Honeydew;
            this.Create_btn.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.Create_btn.Location = new System.Drawing.Point(70, 48);
            this.Create_btn.Name = "Create_btn";
            this.Create_btn.Size = new System.Drawing.Size(147, 43);
            this.Create_btn.TabIndex = 1;
            this.Create_btn.Text = "Create Account";
            this.Create_btn.UseVisualStyleBackColor = false;
            this.Create_btn.Click += new System.EventHandler(this.Create_btn_Click);
            // 
            // Login_btn
            // 
            this.Login_btn.BackColor = System.Drawing.Color.Honeydew;
            this.Login_btn.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.Login_btn.Location = new System.Drawing.Point(70, 118);
            this.Login_btn.Name = "Login_btn";
            this.Login_btn.Size = new System.Drawing.Size(147, 43);
            this.Login_btn.TabIndex = 2;
            this.Login_btn.Text = "Login";
            this.Login_btn.UseVisualStyleBackColor = false;
            this.Login_btn.Click += new System.EventHandler(this.Login_btn_Click);
            // 
            // Exit_btn
            // 
            this.Exit_btn.BackColor = System.Drawing.Color.Honeydew;
            this.Exit_btn.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.Exit_btn.Location = new System.Drawing.Point(70, 188);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(147, 43);
            this.Exit_btn.TabIndex = 3;
            this.Exit_btn.Text = "Exit";
            this.Exit_btn.UseVisualStyleBackColor = false;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // labelWelcome2
            // 
            this.labelWelcome2.AutoSize = true;
            this.labelWelcome2.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome2.Location = new System.Drawing.Point(147, 6);
            this.labelWelcome2.Name = "labelWelcome2";
            this.labelWelcome2.Size = new System.Drawing.Size(123, 24);
            this.labelWelcome2.TabIndex = 4;
            this.labelWelcome2.Text = "\'LITTLE BANK\'";
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.labelWelcome2);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.Login_btn);
            this.Controls.Add(this.Create_btn);
            this.Controls.Add(this.labelWelcome1);
            this.Name = "Welcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.Welcome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWelcome1;
        private System.Windows.Forms.Button Create_btn;
        private System.Windows.Forms.Button Login_btn;
        private System.Windows.Forms.Button Exit_btn;
        private System.Windows.Forms.Label labelWelcome2;
    }
}