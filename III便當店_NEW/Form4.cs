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

namespace III便當店_NEW
{
    public partial class Form4 : Form
    {
        SqlConnectionStringBuilder scsb;

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "IIIFOODSYSTEM";
            scsb.IntegratedSecurity = true;
            SqlConnection con = new SqlConnection(scsb.ToString());
           
            lbox菜單明細.Items.Clear();
            con.Open();
            string strSQL = "select * from products where cname like @SearchCname";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchcName", "%");
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                lbox菜單明細.Items.Add(reader["cname"]);
                lbox菜單明細.Items.Add(reader["product_name"]);
                lbox菜單明細.Items.Add(reader ["price"] + "元");
            }
            reader.Close();
            con.Close();

        }
    }
}
