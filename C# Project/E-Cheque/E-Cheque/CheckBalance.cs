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
    public partial class CheckBalance : Form
    {
        public CheckBalance()
        {
            InitializeComponent();
        }

        private void chkblncSearchbtn_TextChanged(object sender, EventArgs e)
        {
            cn.Open();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Checkbalance where Uid like'" + this.chkblncSearchtxtbox.Text + "%'", cn);
            da.Fill(dt);
            checkbalncdataGridView.DataSource = dt;
            cn.Close();
        }

        private void chkblncbackbtn_Click(object sender, EventArgs e)
        {
            Mainform mn = new Mainform();
            mn.Show();
            this.Hide();
        }
    }
}
