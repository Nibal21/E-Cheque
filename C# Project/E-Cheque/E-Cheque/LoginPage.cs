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
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        DBconnection sql = new DBconnection();

        
        private void passwordcheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if(passwordcheckbox.Checked)
            {
                passwordtextBox.UseSystemPasswordChar = false;
            }
            else
            {
                passwordtextBox.UseSystemPasswordChar = true;
            }
        }

        private void signinbutton_Click(object sender, EventArgs e)
        {
            string Sqlquerry = "select * from Registertable where Usrname=@Usrname and Pwdword=@Pwdword";
            cn.Open();
            SqlCommand cmd = new SqlCommand(Sqlquerry, cn);
            cmd.Parameters.AddWithValue("@Usrname", usernametextBox.Text);
            cmd.Parameters.AddWithValue("@Pwdword", passwordtextBox.Text);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cmd.ExecuteNonQuery();
            cn.Close();
            if(dt.Rows.Count>0)
            {
                Mainform mn = new Mainform();
                mn.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(" Invalid Username and Password! ");
            }

            checkerrorprovider.Clear();
            if (string.IsNullOrEmpty(usernametextBox.Text))
            {
                checkerrorprovider.SetError(usernametextBox, "username is required!");
                usernametextBox.Focus();
            }
            if (string.IsNullOrEmpty(passwordtextBox.Text))
            {
                checkerrorprovider.SetError(passwordtextBox, "password is required!");
                passwordtextBox.Focus();
            }
        }

        private void singupbutton_Click(object sender, EventArgs e)
        {
            SignupPage sp = new SignupPage();
            sp.Show();
        }

        private void forgotpassbutton_Click(object sender, EventArgs e)
        {
            SendCode sc = new SendCode();
            sc.Show();
            this.Hide();
        }
    }
}
