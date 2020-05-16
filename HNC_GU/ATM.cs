using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assesssment_2_BankSystem_AndreaPalombi
{
    public partial class ATM : Form
    {
        public ATM()
        {
            InitializeComponent();
        }

        int amount = 0;
        ArrayList Details = new ArrayList();

        String Account = CreateAcc.tbAccountNo.Text;
        String Pin = CreateAcc.tbPinNo.Text;
        String Balance = CreateAcc.tbBalance.Text;

        private void newbalancedisplay_lbl_Click(object sender, EventArgs e)
        {
            
        }

        private void ATM_Load(object sender, EventArgs e)
            
        {
            Details.Add(Account);
            Details.Add(Pin);
            Details.Add(Balance);

            newbalancedisplay_lbl.Text = "£ " + Details[2].ToString();
        }

        
        private void Continue_btn_Click(object sender, EventArgs e)
        {
            string balance = Details[2].ToString();
            
            if(amount <= Single.Parse(balance))
            {
                newbalancedisplay_lbl.Text = "£ " + (Single.Parse (balance) - amount).ToString();

                MessageBox.Show("Success! You withdrew " + "£ " + amount + "." + Environment.NewLine  + "Your balance is now " + "£ " + (Single.Parse(balance) - amount).ToString() + "." + Environment.NewLine + "Goodbye." + Environment.NewLine + "Little Bank.");

                Welcome Welcome = new Welcome();
                Welcome.Show();
                this.Hide();
           
            } else
            {
                MessageBox.Show("Insufficent balance, sorry. Retry.");
            }
        }

        private void radioButton_10_CheckedChanged(object sender, EventArgs e)
        {
            amount = 10;
        }

        private void radioButton_20_CheckedChanged(object sender, EventArgs e)
        {
            amount = 20;
        }

        private void radioButton_50_CheckedChanged(object sender, EventArgs e)
        {
            amount = 50;
        }

        private void radioButton_100_CheckedChanged(object sender, EventArgs e)
        {
            amount = 100;
        }

        private void radioButton_200_CheckedChanged(object sender, EventArgs e)
        {
            amount = 200;
        }

        private void radioButton_250_CheckedChanged(object sender, EventArgs e)
        {
            amount = 300;
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to exit?", "Exit.", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialog == DialogResult.No)
            {
                
            }
        }
        

        
    }
}
