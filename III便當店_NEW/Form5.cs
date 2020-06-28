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
    public partial class Form5 : Form
    {
        SqlConnectionStringBuilder scsb;
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "IIIFOODSYSTEM";
            scsb.IntegratedSecurity = true;
            lbox菜單明細.Items.Clear();

            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            string strSQL = "select * from products where cname like @SearchcName";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchcName", "%" + tb廠商名稱.Text + "%");
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                lbox菜單明細.Items.Add(reader["cname"]);
                lbox菜單明細.Items.Add(reader["product_name"]);
                lbox菜單明細.Items.Add(reader["price"] + "元");

            }
            reader.Close();
            con.Close();

        }

        private void btn新增菜單_Click(object sender, EventArgs e)
        {
            if (tb廠商名稱.Text.Length > 0) //先判斷
            {
                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();
                string strSQL = "insert into products values(@Newproduct_name, @Newprice, @Newcompany_id, @Newcname)"; //新增 一筆資料 假樣資料測試 有沒有順利 *** 
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@Newproduct_name", tb菜色名稱.Text);
                cmd.Parameters.AddWithValue("@Newprice", tb價錢.Text);
                //cmd.Parameters.AddWithValue("@Newcompany_id", lbl廠商序號.Text);
                //cmd.Parameters.AddWithValue("@Newcname", tb廠商名稱.Text);





                int rows = cmd.ExecuteNonQuery(); //executenonquery回傳影響的筆數 
                SqlDataReader reader = cmd.ExecuteReader();
                {
                    MessageBox.Show(string.Format("資料新增完畢, 共影響{0}筆資料", rows));
                }
            }
            else
            {
                MessageBox.Show("請輸入廠商名稱");
            }


        }

        private void btn菜單修改_Click(object sender, EventArgs e)
        {
            int int序號 = 0;
            Int32.TryParse(lbl廠商序號.Text, out int序號);

            if (int序號 > 0)
            {
                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();
                string strSQL = "update products set product_name=@Newproduct_Name,price=@Newprice,company_id=@Newcompany_id,cname=@Newcname where product_id=@Searchproduct_id";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@Searchproduct_id", int序號);
                cmd.Parameters.AddWithValue("@Newproduct_name", tb菜色名稱.Text);
                cmd.Parameters.AddWithValue("@Newprice", tb價錢.Text);
                cmd.Parameters.AddWithValue("@Newcompany_id", lbl廠商序號.Text);
                cmd.Parameters.AddWithValue("@Newcname", tb廠商名稱.Text);


                int rows = cmd.ExecuteNonQuery(); //不需要回傳 他會顯示影響資料筆數
                con.Close();
                MessageBox.Show(string.Format("資料異動完畢,共影響{0}筆資料", rows));
            }
            else
            {
                MessageBox.Show("請輸入要修改的項目");
            }
        }

        private void btn菜單刪除_Click(object sender, EventArgs e)
        {
            int int序號 = 0;
            Int32.TryParse(lbl菜色代號.Text, out int序號);

            if (int序號 > 0)
            {
                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();
                string strSQL = "delete from products where product_id = @Searchproduct_ID";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@Searchproduct_ID", int序號);

                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(string.Format("資料刪除完畢,共影響{0}筆資料", rows));
                lbl菜色代號.Text = "";
                tb菜色名稱.Text = "";
                tb廠商名稱.Text = "";
                tb價錢.Text = "";

                lbox菜單明細.Items.Clear();
            }
            else
            {
                MessageBox.Show("查無序號");
            }

        }

        private void btn搜尋資料_Click(object sender, EventArgs e)
        {
            lbox菜單明細.Items.Clear();

            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            string strSQL = "select * from products where product_name like @Searchproduct_Name";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@Searchproduct_Name", "%" + tb菜色名稱.Text + "%");
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                lbox菜單明細.Items.Add(reader["product_name"]);
                lbox菜單明細.Items.Add(reader["price"] + "元");
            }
            reader.Close();
            con.Close();
        }
    
    
    }

}
