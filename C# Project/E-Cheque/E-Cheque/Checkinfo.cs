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
    public partial class CheckInfo : Form
    {
        public CheckInfo()
        {
            InitializeComponent();
            Fillcombo();
            accntinfodataGridView1.Visible = false;
            askpwdtxtbox.Visible = false;
            Viewbtn.Visible = false;
            Editbtn.Visible = false;
        }
        public void populateGrid()
        {
            cn.Open();
            String q = "select * from Registertable ";
            SqlDataAdapter da = new SqlDataAdapter(q, cn);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            usrnamecombobox.DataSource = ds.Tables[0];
            cn.Close();
        }

        public void TextboxFilter()
        {
            cn.Open();
            String q = "select * from Registertable where Usrname = '" + usrnamecombobox.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(q, cn);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            accntinfodataGridView1.DataSource = ds.Tables[0];
            cn.Close();
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
                    string name = sd.GetString(10);
                    usrnamecombobox.Items.Add(name);
                }
                cn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
       

        private void Mainform_Load(object sender, EventArgs e)
        {
            populateGrid();
        }

        private void askpwdbtn_Click(object sender, EventArgs e)
        { 
            
        }

        private void resultgridbtn_Click(object sender, EventArgs e)
        {
           
        }

        private void Viewbtn_Click(object sender, EventArgs e)
        {
            string Sqlquerry = "select * from Registertable where Pwdword=@Pwdword;";
            SqlCommand cmd = new SqlCommand(Sqlquerry, cn);
            cmd.Parameters.AddWithValue("@Pwdword", askpwdtxtbox.Text);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                accntinfodataGridView1.Visible = true;
                accntinfodataGridView1.Columns[1].Visible = false;
                accntinfodataGridView1.Columns[2].Visible = false;
                accntinfodataGridView1.Columns[11].Visible = false;
            }
            else
            {
                MessageBox.Show(" Invalid Password! ");
            }
            Editbtn.Visible = true;
        }

        private void Resultbtn_Click(object sender, EventArgs e)
        {
            TextboxFilter();
            Labmsg.Text = "Username " + usrnamecombobox.Text + " Is Selected, Now Password Is Required:";
            askpwdtxtbox.Visible = true;
            Viewbtn.Visible = true;
        }

        private void gbackbtn_Click(object sender, EventArgs e)
        {
            Mainform mn = new Mainform();
            mn.Show();
            this.Hide();
        }

        private void Editbtn_Click(object sender, EventArgs e)
        {
            Edit_Information ei = new Edit_Information();
            ei.Show();
            this.Hide();
        }
    }
}
    

