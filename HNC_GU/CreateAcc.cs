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
    public partial class CreateAcc : Form
    {
        public CreateAcc()
        {
            InitializeComponent();
        }

        public static TextBox tbAccountNo = new TextBox();
        public static TextBox tbPinNo = new TextBox();
        public static TextBox tbBalance = new TextBox();

        private void Login_btn_Click(object sender, EventArgs e)
        {
            
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Welcome Welcome = new Welcome();
            Welcome.Show();
            this.Hide();
            


        }

        private void CreateAcc_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_AccountNo.Text) || (string.IsNullOrEmpty(txt_PinNo.Text) || (string.IsNullOrEmpty(txt_Balance.Text))))
            {
                MessageBox.Show("A valid Account, Pin and Balance are required." + Environment.NewLine + "Please, Try again.");

            }

            else if (txt_AccountNo.Text.Length != 6 || txt_PinNo.Text.Length != 4)
            {
                MessageBox.Show("Please, Account No MUST have 6 digits " + Environment.NewLine + "and Pin No MUST have 4 digits." + Environment.NewLine + "Retry.");
            }
            else
            {
                MessageBox.Show("Your account has been created!" + Environment.NewLine + "Please, Login.");

            
            Welcome Welcome = new Welcome ();
            Welcome.Show();
            this.Hide();
            }




        }

        private void CreateAcc_Load(object sender, EventArgs e)
        {
            tbAccountNo = txt_AccountNo;
            tbPinNo = txt_PinNo;
            tbBalance = txt_Balance;
        }
    }
}
