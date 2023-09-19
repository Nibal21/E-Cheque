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
    public partial class Loading_page : Form
    {
        public Loading_page()
        {
            InitializeComponent();
        }

        private void loadtimer1_Tick(object sender, EventArgs e)
        {
                loadpanel1.Width += 3;
            
                if (loadpanel1.Width >= 750)
            {
                loadtimer1.Stop();
                LoginPage lp = new LoginPage();
                lp.Show();
                this.Hide();
            }
            
            
        }

        private void loadpanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
