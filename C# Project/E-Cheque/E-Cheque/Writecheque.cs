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
    public partial class Writecheque : Form
    {
        public Writecheque()
        {
            InitializeComponent();
            Fillcombo();

        }

        void Fillcombo()
        {
            try
            {
                cn.Open();
                string q = "select * from Registertable";
                SqlCommand cmd = new SqlCommand(q, cn);
                SqlDataReader sd = cmd.ExecuteReader();
                while (sd.Read())
                {
                    string name = sd.GetString(5);
                    comboBox1.Items.Add(name);
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void signaturetxtbox(object sender, EventArgs e)
        {

        }

        private void checkdonebtn_Click(object sender, EventArgs e)
        {
           MessageBox.Show(" The cheque is written. ");

            Mainform mn = new Mainform();
            mn.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void paytextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(paytextBox.Text) == true)
            {
                paytextBox.Focus();
                errorProvider1.SetError(this.paytextBox, "Please fill the pay to box !!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void sumoftakatextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(sumoftakatextBox.Text) == true)
            {
                sumoftakatextBox.Focus();
                errorProvider1.SetError(this.sumoftakatextBox, "Please fill the box !!");
            }
        }

        private void amounttextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(amounttextBox.Text) == true)
            {
                amounttextBox.Focus();
                errorProvider1.SetError(this.amounttextBox, "Please fill the box !!");
            }
        }

        private void signtextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(signtextBox.Text) == true)
            {
                signtextBox.Focus();
                errorProvider1.SetError(this.signtextBox, "Please fill the box !!");
            }
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox1.Text) == true)
            {
                comboBox1.Focus();
                errorProvider1.SetError(this.comboBox1, "Please fill the box !!");
            }
        }
    }
}
