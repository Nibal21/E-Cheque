using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static E_Cheque.DBconnection;

namespace E_Cheque
{
    public partial class Edit_Information : Form
    {
        public Edit_Information()
        {
            InitializeComponent();
        }
        public void disp_data()
        {

            cn.Open();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Registertable";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            updateddataGridView.DataSource = dt;
            cn.Close();

        }
        public void disp_data2()
        {

            cn.Open();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Additionaldata";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            additionaldataGridView.DataSource = dt;
            cn.Close();

        }
        private void edtgobackbtn_Click(object sender, EventArgs e)
        {
            CheckInfo ci = new CheckInfo();
            ci.Show();
            this.Close();
        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            cn.Open();

            string UserId = userIdfetchtxtbox.Text;
            string Usrname = updtusrnmtxtbox.Text;

            string q = "UPDATE Registertable SET Usrname= '" +Usrname+ "'  Where Uid = " + UserId;

            SqlCommand cmd = new SqlCommand(q, cn);
            cmd.ExecuteNonQuery();
            cn.Close();
            userIdfetchtxtbox.Text = "";
            updtusrnmtxtbox.Text = "";
            
            disp_data();
            updateddataGridView.Columns[1].Visible = false;
            updateddataGridView.Columns[2].Visible = false;
            updateddataGridView.Columns[3].Visible = false;
            updateddataGridView.Columns[4].Visible = false;
            updateddataGridView.Columns[5].Visible = false;
            updateddataGridView.Columns[6].Visible = false;
            updateddataGridView.Columns[7].Visible = false;
            updateddataGridView.Columns[8].Visible = false;
            updateddataGridView.Columns[9].Visible = false;
            updateddataGridView.Columns[11].Visible = false;
            MessageBox.Show(" New Username is Updated.");
        }

        private void fetchbtn_Click(object sender, EventArgs e)
        {
            cn.Open();
            string UserId = userIdfetchtxtbox.Text;
            string q = "Select * from Registertable where Uid =" + UserId;
            SqlCommand cmd = new SqlCommand(q, cn);
            var reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                updtusrnmtxtbox.Text = reader["Usrname"].ToString();
            }
            else
            {
                MessageBox.Show(" No Record Found! ");
            }
            cn.Close();

        }

        private void Edtaddbtn_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Additionaldata values('" + addphntxtbox.Text + "','" + addaddrstxtbox.Text + "','" + addstreettxtbox.Text + "')";
            cmd.ExecuteNonQuery();
            cn.Close();
            addphntxtbox.Text = "";
            addaddrstxtbox.Text = "";
            addstreettxtbox.Text = "";
            disp_data2();
            MessageBox.Show("Additional data is added successfully");
        }

       
    }
}
