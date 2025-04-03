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

namespace fullnavigation
{
    public partial class Form1 : Form
    {
        int tr = 0, rp = 0, id = 0, sid = 0;
        DataTable dt;
        DataSet ds;
        public static SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\crud.mdf;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }
     
        private void form1_Load(object sender,EventArgs e)
        {
            LoadData();
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (btnInsert.Text != "&save")
            {
                if (txtsnm.Text != string.Empty && comboBox1.Text != "--select course--")
                {
                    string sql = "insert into student1 values"+"('" + txtsnm.Text + "','"+txtmb.Text+"','" + comboBox1.Text + "')";
                    SqlDataAdapter da = new SqlDataAdapter(sql, cn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    LoadData();
                    Clear(); 
                }
                else
                {
                    MessageBox.Show("please Enter Values", "crud", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Clear();
                }
            }
            else
            {
                btnInsert.Text = "&save";
                Clear();
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }
        }
        private void btnlast_Click(object sender, EventArgs e)
        {
            if (tr > 0)
            {
                rp = tr;
                Navigate();
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
                btnInsert.Text = "&Insert";
            }
        }

        private void btnprev_Click(object sender, EventArgs e)
        {
            if (rp > 0)
            {
                rp--;
                Navigate();
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
                btnInsert.Text = "&Insert";
            }
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            if (rp < tr)
            {
                rp++;
                Navigate();
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
                btnInsert.Text = "&Insert";
            }
        }

        private void btnfirst_Click(object sender, EventArgs e)
        {
            {
                rp = 0;
                Navigate();
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
                btnInsert.Text = "&Insert";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string sql = "Delete FROM student1 where Id='" + id + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            LoadData();
            txtsnm.Focus();
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string sql = "Update student1 set studentname='" + txtsnm.Text + "',mobileno='"+txtmb.Text+"',course='"+comboBox1.Text+"' where id='"+id+"'";
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            LoadData();
        }
        private void LoadData()
        {
            string sql = "select * from coruse";
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            ds = new DataSet();
            ds.Tables.Add("Table1");
            ds.Tables.Add("Table2");
            da.Fill(ds.Tables[0]);
            if (ds.Tables[0].Rows.Count > 0)
                { 
                    comboBox1.DataSource = ds.Tables[0];
                    comboBox1.DisplayMember = "course";
                }
                comboBox1.Text = "--Select Course--";
                string sql1 = "select * from student1";
                SqlDataAdapter da1 = new SqlDataAdapter(sql1, cn);
                da1.Fill(ds.Tables[1]);
                if(ds.Tables[1].Rows.Count>0)
                    {
                    tr = ds.Tables[1].Rows.Count - 1;
                    dataGridView1.DataSource = ds.Tables["Table2"];
                }
        }
        private void Clear()
        {
            txtsnm.Text = "";
            txtmb.Text = "";
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            comboBox1.Text = "--Select Course--";
            txtsnm.Focus();
        }
        private void Navigate()
        {
            if (sid == 0)
            {
                txtsnm.Text = ds.Tables[1].Rows[rp][1].ToString();
                txtmb.Text = ds.Tables[1].Rows[rp][2].ToString();
                comboBox1.Text = ds.Tables[1].Rows[rp][3].ToString();
                id = Convert.ToInt32(ds.Tables[1].Rows[rp][0]);
            }
            else
            {
                string sql = "select * from student1 where id='" + sid + "'";
                SqlDataAdapter da = new SqlDataAdapter(sql, cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                txtsnm.Text = ds.Tables[0].Rows[rp][1].ToString();

                comboBox1.Text = dt.Rows[0][2].ToString();

            }
        }
        private void combobox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Text = "--Select Course--";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

      
    }
}
