using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Cheque
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckInfo ci = new CheckInfo();
            ci.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CheckBalance cb = new CheckBalance();
            cb.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Writecheque wr = new Writecheque();
            wr.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 tf = new Form1();
            tf.Show();
            this.Hide();
        }
    }
}
