using System;
using System.Collections;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void back_CreateAcc_btn_Click(object sender, EventArgs e)
        {
            Welcome Welcome = new Welcome();
            Welcome.Show();
            this.Hide();
            
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {



            string Account = CreateAcc.tbAccountNo.Text;
            string Pin = CreateAcc.tbPinNo.Text;
            string Balance = CreateAcc.tbBalance.Text;

            ArrayList Details = new ArrayList();


            Details.Add(Account);
            Details.Add(Pin);
            Details.Add(Balance);

            Boolean checkAccount = Details.Contains(tbAccount.Text);
            Boolean checkPin = Details.Contains(tbPin.Text);



            for (int i = 0; i < Details.Count; i++)
            {
                if (Details.Contains(tbAccount.Text)) { 
                    checkAccount = true;
            }
            else 
                    checkAccount = false;
           }



            for (int i = 0; i < Details.Count; i++)
            {
                if (Details.Contains(tbPin.Text))
                {
                    checkPin = true;
                }
                else
                    checkPin = false;
            }
            
          
            if (tbAccount.Text == string.Empty || tbPin.Text == string.Empty)
           {
               MessageBox.Show("Invalid Account or Pin, please retry.");
           }
          else if (checkAccount == false)
          {
              MessageBox.Show("This account doesn't exist. Retry.");
         }
         else if (checkPin == false)
         {
             MessageBox.Show("Wrong Password.");
         }
         else
         {

          balanceDisplay_lbl.Text = "£ " + Details[2].ToString() + " ";
               withdraw_btn.Enabled = true;
          }

    }

        
  
    private void balanceDisplay_lbl_Click(object sender, EventArgs e)
        {
            
        }

        private void Login_Load(object sender, EventArgs e)
        {
            withdraw_btn.Enabled = false;
        }

        private void withdraw_btn_Click(object sender, EventArgs e)
        {
            ATM ATM = new ATM();
            ATM.Show();
            this.Hide();
        }
    }

    internal class ArrayList : System.Collections.ArrayList
    {
    }
}
