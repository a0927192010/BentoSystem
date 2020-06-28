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
    public partial class Form2 : Form
    {
        SqlConnectionStringBuilder scsb;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "IIIFOODSYSTEM";
            scsb.IntegratedSecurity = true;
            SqlConnection con = new SqlConnection(scsb.ToString());
            lbox搜尋結果.Items.Clear();
            con.Open();
            string strSQL = "select * from student where name like @Searchname";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchName", "%");
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                lbox搜尋結果.Items.Add(reader["stu_id"]);
                lbox搜尋結果.Items.Add(reader["name"]);
               
            }
            reader.Close();
            con.Close();
        }

        private void btn新增資料_Click(object sender, EventArgs e)
        {
            if (tb姓名.Text.Length > 0) //先判斷
            {
                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();
                string strSQL = "insert into student values(@Searchname,@Newphone,@Newclass)"; //新增 一筆資料 假樣資料測試 有沒有順利 *** 
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@Searchname", tb姓名.Text);
                cmd.Parameters.AddWithValue("@Newphone", tb電話.Text);
                cmd.Parameters.AddWithValue("@Newclass", tb期別.Text);
                
    
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
            Int32.TryParse(lbl學員序號.Text, out int序號);

            if (int序號 > 0)
            {
                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();
                string strSQL = "update student set name=@NewName,phone=@NewPhone,class=@Newclass where stu_id=@Searchstu_id";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@Searchstu_id", int序號);
                cmd.Parameters.AddWithValue("@NewName", tb姓名.Text);
                cmd.Parameters.AddWithValue("@NewPhone", tb電話.Text);
                cmd.Parameters.AddWithValue("@Newclass", tb期別.Text);

                int rows = cmd.ExecuteNonQuery(); //不需要回傳 他會顯示影響資料筆數
                con.Close();
                MessageBox.Show(string.Format("資料異動完畢,共影響{0}筆資料", rows));
            }
            else
            {
                MessageBox.Show("請輸入要修改的項目");
            }
        }

        private void btn刪除資料_Click(object sender, EventArgs e)
        {
            int int序號 = 0;
            Int32.TryParse(lbl學員序號.Text, out int序號);

            if (int序號 > 0)
            {
                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();
                string strSQL = "delete from student where stu_id = @SearchID";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", int序號);

                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(string.Format("資料刪除完畢,共影響{0}筆資料", rows));
                lbl學員序號.Text = "";
                tb姓名.Text = "";
                tb電話.Text = "";
                tb期別.Text = "";
           
                lbox搜尋結果.Items.Clear();
            }
            else
            {
                MessageBox.Show("查無序號");
            }

        }

        private void lbox搜尋結果_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn搜尋資料_Click(object sender, EventArgs e)
        {
            lbox搜尋結果.Items.Clear();
            {
                if (tb姓名.Text.Length > 0) //要求回應
                { //搜尋姓名
                    SqlConnection con = new SqlConnection(scsb.ToString()); //用SCSB來的
                    con.Open();
                    string strSQL = "select * from student where name like @searchName"; //@searchName 一定要用參數帶入法 
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@searchName", "%" + tb姓名.Text + "%"); //SQL語法 %模糊搜尋 參數名稱大小寫要一致
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        lbl學員序號.Text = string.Format("{0}", reader["stu_id"]);
                        tb姓名.Text = string.Format("{0}", reader["name"]);
                        tb電話.Text = string.Format("{0}", reader["phone"]);
                        tb期別.Text = string.Format("{0}", reader["class"]);
                        MessageBox.Show("查詢成功");

                    }
                    else
                    {
                        MessageBox.Show("查無此人"); //查無此人 後 清空欄位
                        lbl學員序號.Text = "";
                        tb姓名.Text = "";
                        tb期別.Text = "";
                        tb電話.Text = "";
                 



                    }
                    reader.Close();
                    con.Close();


                }
                else if (tb姓名.Text.Length > 0)
                {

                }
                else
                {

                }
                MessageBox.Show("請輸入搜尋字串");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbox搜尋結果.Items.Clear();

            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            string strSQL = "select * from student where name like @SearchName";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchName", "%" + tb姓名.Text + "%");
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                lbox搜尋結果.Items.Add(reader["name"]);
            }
            reader.Close();
            con.Close();
        }
    }
}
