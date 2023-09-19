using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static E_Cheque.DBconnection; 

namespace E_Cheque
{
    public partial class SignupPage : Form
    {
        public SignupPage()
        {
            InitializeComponent();
        }

        private void SingupPage_Load(object sender, EventArgs e)
        {

        }

        private void gobacklinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginPage lp = new LoginPage();
            lp.Show();
            this.Hide();
        }

        private void registerbutton_Click(object sender, EventArgs e)
        {
            string Sqlquerry = "insert into Registertable values(@Fname,@Lname,@Gender,@Nidnum,@Email,@Bank,@Accounttyp,@Accountnum,@Signtr,@Usrname,@Pwdword)";
            cn.Open();
            SqlCommand cmd = new SqlCommand(Sqlquerry, cn);
            cmd.Parameters.AddWithValue("@Fname", firstnametextBox.Text);
            cmd.Parameters.AddWithValue("@Lname", lastnametextBox.Text);
            cmd.Parameters.AddWithValue("@Gender", gendercombobox.Text);
            cmd.Parameters.AddWithValue("@Nidnum", nidnumbertextBox.Text);
            cmd.Parameters.AddWithValue("@Email", emailtextBox.Text);
            cmd.Parameters.AddWithValue("@Bank", selectbankcomboBox.Text);
            cmd.Parameters.AddWithValue("@Accounttyp", accnttypcombobox.Text);
            cmd.Parameters.AddWithValue("@Accountnum", accountnumbertextBox.Text);
            cmd.Parameters.AddWithValue("@Signtr", signaturetextBox.Text);
            cmd.Parameters.AddWithValue("@Usrname", setusernametextBox.Text);
            cmd.Parameters.AddWithValue("@Pwdword", setpasswordtextBox.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show(" User Registerred Successfully! ");
            cn.Close();

            LoginPage lp = new LoginPage();
            lp.Show();
            this.Hide();
        }

        private void confirmpasswordtextBox_Leave(object sender, EventArgs e)
        {
            if (setpasswordtextBox.Text != confirmpasswordtextBox.Text)
            {
                MessageBox.Show("Passworda is not matched!");
                confirmpasswordtextBox.Focus();
                return;
            }
        }

        private void firstnametextBox_Leave(object sender, EventArgs e)
        {
           
        }
    }
        }

