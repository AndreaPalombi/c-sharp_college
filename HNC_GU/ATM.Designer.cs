namespace Assesssment_2_BankSystem_AndreaPalombi
{
    partial class ATM
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
            this.newbalancedisplay_lbl = new System.Windows.Forms.Label();
            this.Continue_btn = new System.Windows.Forms.Button();
            this.Back_btn = new System.Windows.Forms.Button();
            this.radioButton_10 = new System.Windows.Forms.RadioButton();
            this.radioButton_20 = new System.Windows.Forms.RadioButton();
            this.radioButton_50 = new System.Windows.Forms.RadioButton();
            this.radioButton_300 = new System.Windows.Forms.RadioButton();
            this.radioButton_200 = new System.Windows.Forms.RadioButton();
            this.radioButton_100 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SkyBlue;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(13, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Balance";
            // 
            // newbalancedisplay_lbl
            // 
            this.newbalancedisplay_lbl.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.newbalancedisplay_lbl.Location = new System.Drawing.Point(150, 139);
            this.newbalancedisplay_lbl.Name = "newbalancedisplay_lbl";
            this.newbalancedisplay_lbl.Size = new System.Drawing.Size(100, 23);
            this.newbalancedisplay_lbl.TabIndex = 1;
            this.newbalancedisplay_lbl.Click += new System.EventHandler(this.newbalancedisplay_lbl_Click);
            // 
            // Continue_btn
            // 
            this.Continue_btn.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.Continue_btn.Location = new System.Drawing.Point(16, 185);
            this.Continue_btn.Name = "Continue_btn";
            this.Continue_btn.Size = new System.Drawing.Size(100, 43);
            this.Continue_btn.TabIndex = 2;
            this.Continue_btn.Text = "Continue";
            this.Continue_btn.UseVisualStyleBackColor = true;
            this.Continue_btn.Click += new System.EventHandler(this.Continue_btn_Click);
            // 
            // Back_btn
            // 
            this.Back_btn.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.Back_btn.Location = new System.Drawing.Point(166, 185);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(100, 43);
            this.Back_btn.TabIndex = 3;
            this.Back_btn.Text = "Exit";
            this.Back_btn.UseVisualStyleBackColor = true;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // radioButton_10
            // 
            this.radioButton_10.AutoSize = true;
            this.radioButton_10.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.radioButton_10.Location = new System.Drawing.Point(13, 23);
            this.radioButton_10.Name = "radioButton_10";
            this.radioButton_10.Size = new System.Drawing.Size(62, 25);
            this.radioButton_10.TabIndex = 4;
            this.radioButton_10.TabStop = true;
            this.radioButton_10.Text = "£ 10";
            this.radioButton_10.UseVisualStyleBackColor = true;
            this.radioButton_10.CheckedChanged += new System.EventHandler(this.radioButton_10_CheckedChanged);
            // 
            // radioButton_20
            // 
            this.radioButton_20.AutoSize = true;
            this.radioButton_20.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.radioButton_20.Location = new System.Drawing.Point(13, 60);
            this.radioButton_20.Name = "radioButton_20";
            this.radioButton_20.Size = new System.Drawing.Size(62, 25);
            this.radioButton_20.TabIndex = 5;
            this.radioButton_20.TabStop = true;
            this.radioButton_20.Text = "£ 20";
            this.radioButton_20.UseVisualStyleBackColor = true;
            this.radioButton_20.CheckedChanged += new System.EventHandler(this.radioButton_20_CheckedChanged);
            // 
            // radioButton_50
            // 
            this.radioButton_50.AutoSize = true;
            this.radioButton_50.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.radioButton_50.Location = new System.Drawing.Point(12, 96);
            this.radioButton_50.Name = "radioButton_50";
            this.radioButton_50.Size = new System.Drawing.Size(62, 25);
            this.radioButton_50.TabIndex = 6;
            this.radioButton_50.TabStop = true;
            this.radioButton_50.Text = "£ 50";
            this.radioButton_50.UseVisualStyleBackColor = true;
            this.radioButton_50.CheckedChanged += new System.EventHandler(this.radioButton_50_CheckedChanged);
            // 
            // radioButton_300
            // 
            this.radioButton_300.AutoSize = true;
            this.radioButton_300.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.radioButton_300.Location = new System.Drawing.Point(152, 96);
            this.radioButton_300.Name = "radioButton_300";
            this.radioButton_300.Size = new System.Drawing.Size(71, 25);
            this.radioButton_300.TabIndex = 9;
            this.radioButton_300.TabStop = true;
            this.radioButton_300.Text = "£ 300";
            this.radioButton_300.UseVisualStyleBackColor = true;
            this.radioButton_300.CheckedChanged += new System.EventHandler(this.radioButton_250_CheckedChanged);
            // 
            // radioButton_200
            // 
            this.radioButton_200.AutoSize = true;
            this.radioButton_200.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.radioButton_200.Location = new System.Drawing.Point(153, 60);
            this.radioButton_200.Name = "radioButton_200";
            this.radioButton_200.Size = new System.Drawing.Size(71, 25);
            this.radioButton_200.TabIndex = 8;
            this.radioButton_200.TabStop = true;
            this.radioButton_200.Text = "£ 200";
            this.radioButton_200.UseVisualStyleBackColor = true;
            this.radioButton_200.CheckedChanged += new System.EventHandler(this.radioButton_200_CheckedChanged);
            // 
            // radioButton_100
            // 
            this.radioButton_100.AutoSize = true;
            this.radioButton_100.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.radioButton_100.Location = new System.Drawing.Point(153, 23);
            this.radioButton_100.Name = "radioButton_100";
            this.radioButton_100.Size = new System.Drawing.Size(71, 25);
            this.radioButton_100.TabIndex = 7;
            this.radioButton_100.TabStop = true;
            this.radioButton_100.Text = "£ 100";
            this.radioButton_100.UseVisualStyleBackColor = true;
            this.radioButton_100.CheckedChanged += new System.EventHandler(this.radioButton_100_CheckedChanged);
            // 
            // ATM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.radioButton_300);
            this.Controls.Add(this.radioButton_200);
            this.Controls.Add(this.radioButton_100);
            this.Controls.Add(this.radioButton_50);
            this.Controls.Add(this.radioButton_20);
            this.Controls.Add(this.radioButton_10);
            this.Controls.Add(this.Back_btn);
            this.Controls.Add(this.Continue_btn);
            this.Controls.Add(this.newbalancedisplay_lbl);
            this.Controls.Add(this.label1);
            this.Name = "ATM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATM";
            this.Load += new System.EventHandler(this.ATM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label newbalancedisplay_lbl;
        private System.Windows.Forms.Button Continue_btn;
        private System.Windows.Forms.Button Back_btn;
        private System.Windows.Forms.RadioButton radioButton_10;
        private System.Windows.Forms.RadioButton radioButton_20;
        private System.Windows.Forms.RadioButton radioButton_50;
        private System.Windows.Forms.RadioButton radioButton_300;
        private System.Windows.Forms.RadioButton radioButton_200;
        private System.Windows.Forms.RadioButton radioButton_100;
    }
}