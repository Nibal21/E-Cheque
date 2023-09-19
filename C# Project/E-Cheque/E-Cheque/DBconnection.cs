using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace E_Cheque
{
    class DBconnection
    {
        public static SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\C# Project\fresh start\Data base queries\E-Cheque\Projectdatabase.mdf;Integrated Security=True;Connect Timeout=30");
    }
}
