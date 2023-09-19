using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static E_Cheque.DBconnection;
using System.Data.SqlClient;

namespace E_Cheque
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void disp_data()
        {

            cn.Open();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from tfhistory";
            
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            tfdataGridView1.DataSource = dt;
            cn.Close();

        }
        private void tfdataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from tfhistory ";
            cmd.ExecuteNonQuery();
            cn.Close();
            disp_data();
            MessageBox.Show("record deleted successfully");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            disp_data();
        }

        private void gbackbtn_Click(object sender, EventArgs e)
        {
            Mainform mn = new Mainform();
            mn.Show();
            this.Hide();
        }
    }
}
