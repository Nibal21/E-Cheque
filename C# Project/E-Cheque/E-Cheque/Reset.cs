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
    
    public partial class Reset : Form
    {
        string email = SendCode.to;
        public Reset()
        {
            InitializeComponent();
        }

        private void resetbacklinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SendCode sc = new SendCode();
            sc.Show();
            this.Hide();
        }

        private void resetbutton_Click(object sender, EventArgs e)
        {
            string password = resetconpasstextBox.Text;
            if (resetnewpasstextBox.Text == password)
            {

                string q = "update Registertable set[Pwdword]= '" + password + "'where Email='" + email + "'";
                SqlCommand cmd = new SqlCommand(q, cn);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();

                MessageBox.Show(" Password Successfully Changed! ");

            }
            else
            {
                MessageBox.Show(" Sorry your New Password Dosn't Match! ");
            }

            LoginPage lp = new LoginPage();
            lp.Show();
            this.Hide();
        }
    }
}
