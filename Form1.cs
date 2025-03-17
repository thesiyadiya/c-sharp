using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\diya\WindowsFormsApplication1\WindowsFormsApplication1\bin\Debug\bscit.mdf;Integrated Security=True");
            cn.Open();
            String Sql = "select * from bca where Username='" + unm.Text + "'and Password='" + pwd.Text + "'";
            /* //connected Architecture
             SqlCommand cmd = new SqlCommand(Sql, cn);
             SqlDataReader dr = null;
             dr = cmd.ExecuteReader();
             if(dr.HasRows)
             {
                 MessageBox.Show("Welcome");
             }
             else
             {
                 MessageBox.Show("Invalid");
             }
             cn.Close();
             */
            //Disconnected Architecture
            SqlDataAdapter da = new SqlDataAdapter(Sql, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if(dt.Rows.Count==1)
            {
                MessageBox.Show("Welcome");
            }
            else
            {
                MessageBox.Show("Invalid");
            }
        }

  
    }
}
