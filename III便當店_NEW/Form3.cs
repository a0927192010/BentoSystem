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
    public partial class Form3 : Form
    {
        SqlConnectionStringBuilder scsb;

        public Form3()
        {
            InitializeComponent();
        }

        private void btn新增資料_Click(object sender, EventArgs e)
        {
            if (tb廠商名稱.Text.Length > 0) //先判斷
            {
                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();
                string strSQL = "insert into company values(@Searchcname,@Newaddress,@Newphone)"; //新增 一筆資料 假樣資料測試 有沒有順利 *** 
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@Searchcname", tb廠商名稱.Text);
                cmd.Parameters.AddWithValue("@Newaddress", tb地址.Text);
                cmd.Parameters.AddWithValue("@Newphone", tb電話.Text);
                


                int rows = cmd.ExecuteNonQuery(); //executenonquery回傳影響的筆數 
                con.Close();
                MessageBox.Show(string.Format("資料新增完畢, 共影響{0}筆資料", rows));

            }
            else
            {
                MessageBox.Show("請輸入姓名");
            }
        }

        private void btn修改資料_Click(object sender, EventArgs e)
        {
            int int序號 = 0;
            Int32.TryParse(lbl廠商序號.Text, out int序號);

            if (int序號 > 0)
            {
                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();
                string strSQL = "update company set cname=@NewcName,address=@Newaddress,phone=@NewPhone where company_id=@Searchcompany_id";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@Searchcompany_id", int序號);
                cmd.Parameters.AddWithValue("@NewcName", tb廠商名稱.Text);
                cmd.Parameters.AddWithValue("@Newaddress", tb地址.Text);
                cmd.Parameters.AddWithValue("@NewPhone", tb電話.Text);
                

                int rows = cmd.ExecuteNonQuery(); //不需要回傳 他會顯示影響資料筆數
                con.Close();
                MessageBox.Show(string.Format("資料異動完畢,共影響{0}筆資料", rows));
            }
            else
            {
                MessageBox.Show("請輸入要修改的項目");
            }
        }

        private void btn搜尋資料_Click(object sender, EventArgs e)
        {
            lbox搜尋結果.Items.Clear();
            {
                if (tb廠商名稱.Text.Length > 0) //要求回應
                { //搜尋姓名
                    SqlConnection con = new SqlConnection(scsb.ToString()); //用SCSB來的
                    con.Open();
                    string strSQL = "select * from company where cname like @searchcName"; //@searchName 一定要用參數帶入法 
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@searchcName", "%" + tb廠商名稱.Text + "%"); //SQL語法 %模糊搜尋 參數名稱大小寫要一致
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        lbl廠商序號.Text = string.Format("{0}", reader["company_id"]);
                        tb廠商名稱.Text = string.Format("{0}", reader["cname"]);
                        tb地址.Text = string.Format("{0}", reader["address"]);
                        tb電話.Text = string.Format("{0}", reader["phone"]);
                        MessageBox.Show("查詢成功");

                    }
                    else
                    {
                        MessageBox.Show("查無此人"); //查無此人 後 清空欄位
                        lbl廠商序號.Text = "";
                        tb廠商名稱.Text = "";
                        tb地址.Text = "";
                        tb電話.Text = "";




                    }
                    reader.Close();
                    con.Close();


                }
                else if (tb廠商名稱.Text.Length > 0)
                {

                }
                else
                {

                }
                MessageBox.Show("請輸入搜尋字串");
            }
        }

        private void btn刪除資料_Click(object sender, EventArgs e)
        {
            int int序號 = 0;
            Int32.TryParse(lbl廠商序號.Text, out int序號);

            if (int序號 > 0)
            {
                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();
                string strSQL = "delete from company where company_id = @SearchID";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", int序號);

                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(string.Format("資料刪除完畢,共影響{0}筆資料", rows));
                lbl廠商序號.Text = "";
                tb廠商名稱.Text = "";
                tb地址.Text = "";
                tb電話.Text = "";

                lbox搜尋結果.Items.Clear();
            }
            else
            {
                MessageBox.Show("查無序號");
            }

        }

        private void btn廠商名單_Click(object sender, EventArgs e)
        {
            lbox搜尋結果.Items.Clear();

            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            string strSQL = "select * from company where cname like @SearchcName";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchcName", "%" + tb廠商名稱.Text + "%");
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                lbox搜尋結果.Items.Add(reader["cname"]);
            }
            reader.Close();
            con.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "IIIFOODSYSTEM";
            scsb.IntegratedSecurity = true;
            lbox搜尋結果.Items.Clear();

            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            string strSQL = "select * from company where cname like @SearchcName";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchcName", "%" + tb廠商名稱.Text + "%");
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                lbox搜尋結果.Items.Add(reader["company_id"]);
                lbox搜尋結果.Items.Add(reader["cname"]);
            }
            reader.Close();
            con.Close();
        }
    }
}
