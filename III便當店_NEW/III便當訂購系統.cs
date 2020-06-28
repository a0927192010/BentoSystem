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
using static System.Console;

namespace III便當店_NEW
{
    public partial class III便當訂購系統 : Form
    {
        SqlConnectionStringBuilder scsb;
        SqlConnection con;
        SqlDataAdapter adapter;
        int 份數 = 0;
        double 單價 = 0;
        double 總價 = 0;
        DataTable dTable;

        public III便當訂購系統()
        {
            InitializeComponent();
        }

        private void III便當訂購系統_Load(object sender, EventArgs e)
        {

            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "IIIFOODSYSTEM";
            scsb.IntegratedSecurity = true;

            cbFill期別();
            cbFill店家();
            GridViewGetdata("select item_no as 訂單編號,stu_id as 學生編號,product_id as 商品代號,price as 價格,company_id as 廠商代號 from order_detail");
            KyoStudunt();
            timer1.Enabled = true;
            lbl單價.Text = 單價.ToString();
            //SetupLayout();
            //SetupDataGridView();
            //PopulateDataGridView();
        }
        public void KyoStudunt()
        {
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("select name from student", con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lb值日生.Text = string.Format("{0}", reader["name"]);

            }
            con.Close();
            reader.Close();
        }
        public void GridViewGetdata(String cmd)
        {
            String conString = "Integrated Security = true;Persist Security Info = false; Initial Catalog = IIIFOODSYSTEM; Data Source = .";
            adapter = new SqlDataAdapter(cmd, conString);
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(adapter);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;

        }

        private void cb期別_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cb姓名.SelectedIndex < 0) //啟動索引方法
            {
                return;
            }

            changeCbName();

        }

        private void changeCbName()
        {
            //WriteLine(cb姓名.SelectedIndex);
            cb姓名.SelectedIndex = cb期別.SelectedIndex; //取得"名子"索引"期別"的方法

        }

        private void changeCbCName()
        {
            cb品名.SelectedIndex = cb店家.SelectedIndex;

        }
        void cbFill期別()
        {
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("select distinct(class) from student", con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cb期別.Items.Add(reader["class"]);
            }
            con.Close();
            reader.Close();
        }
        void cbFill店家()
        {
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("select distinct(cname) from products", con);
            //string strSQL = "select * from products";
            //SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cb店家.Items.Add(reader["cname"]);

            }
            con.Close();
            reader.Close();
        }


        private void cb店家_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn學員資料_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void btn廠商資料_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void btn菜單_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }

        private void cb期別_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cb姓名.Items.Clear();
            cb姓名.Text = "";
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from student where class = " + cb期別.SelectedItem.ToString(), con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cb姓名.Items.Add(reader["name"]);
            }
            con.Close();
            reader.Close();
        }

        private void cb店家_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cb品名.Items.Clear();
            cb品名.Text = "";
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            //SqlCommand cmd = new SqlCommand("select * from products where cname" );
            string strSQL = "select * from products where cname=N'" + cb店家.SelectedItem.ToString() + "'";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cb品名.Items.Add(reader["product_name"]);
            }
            con.Close();
            reader.Close();
        }

        private void btn菜單資料維護_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.ShowDialog();
        }

        private void cb品名_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl單價.Text = "";
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            string strSQL = "select * from products where product_name=N'" + cb品名.SelectedItem.ToString() + "'";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader(); //用方法建立 reader

            while (reader.Read()) //用這個bool方法的 外迴圈
            {
                lbl單價.Text = string.Format("{0}", reader["price"]);
            }


            reader.Close(); //datebast 先建立要先關 後建立後關
            con.Close();


        }

        private void btn加_Click(object sender, EventArgs e)
        {
            份數 += 1;
            btn減.Enabled = true;
            tb數量.Text = 份數.ToString();
            lbl份數總價.Text = (Convert.ToInt32(tb數量.Text) * Convert.ToInt32(lbl單價.Text)).ToString();

        }

        private void btn減_Click(object sender, EventArgs e)
        {
            份數 -= 1;
            if (份數 < 0)
            {
                份數 = 0;
                btn減.Enabled = false;
            }
            tb數量.Text = 份數.ToString();
        }

        private void btn加入訂單_Click(object sender, EventArgs e)
        {
            if (tb數量.Text.Length > 0 && Convert.ToInt32(tb數量.Text) > 0)
            {


                DialogResult a;

                if (cb店家.Enabled == true)
                {
                    a = MessageBox.Show(cb期別.Text + "期別的" + (cb姓名.Text) + "同學你好，決定好此店家了嗎？", "提示視窗", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    //dailystu();

                }
                else
                {
                    a = MessageBox.Show(cb姓名.Text + "同學你好，你要訂購的是「" + cb品名.Text + "」 數量" + tb數量.Text + "份嗎？", "提示視窗", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                }


                if (a == DialogResult.Yes)
                {


                    SqlConnection con = new SqlConnection(scsb.ToString());
                    con.Open();
                    string strSQL = "insert into order_detail values(" +
                        "(select product_id from products where product_name = N'" + cb品名.SelectedItem.ToString() + "')," +
                        "(select distinct company_id from products where cname = N'" + cb店家.SelectedItem.ToString() + "'),'" +
                        lbl份數總價.Text + "',(select stu_id from student where name = N'" + cb姓名.SelectedItem.ToString() + "'))";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    GridViewGetdata("select item_no as 訂單編號,stu_id as 學生編號,product_id as 商品代號,price as 價格,company_id as 廠商代號 from order_detail");
                    MessageBox.Show("資料送出完成 !!!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
            }
            else
            {
                MessageBox.Show("請選擇數量 !!!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl時間.Text = string.Format("{0}", DateTime.Now);

        }


        private void tb數量_TextChanged(object sender, EventArgs e)
        {

            if (tb數量.Text.Length > 0)
            {
                bool ifNum = Int32.TryParse(tb數量.Text, out 份數);

                if (ifNum && 份數 >= 0)
                {
                    //正確輸入;
                    btn減.Enabled = true;
                }
                else
                {
                    //錯誤輸入;
                    MessageBox.Show("份數輸入錯誤", "輸入錯誤",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    份數 = 0;
                    tb數量.Text = "0";
                }
            }
            else
            {
                份數 = 0;
            }
            //計算總價();

        }

        private void btn訂單修改_Click(object sender, EventArgs e)
        {

        }

        private void btn訂單刪除_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection(scsb.ToString());
            //con.Open();

            if (MessageBox.Show("您確定刪除？", "刪除？", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();
                string strSQL = "select *  from order_detail";
                adapter = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand(strSQL, con);
                adapter.SelectCommand = cmd;
                cmd.ExecuteNonQuery();
                //cmd = new SqlCommand(selectStr, con);
                //adapter.SelectCommand = cmd;
                dTable = new DataTable();
                adapter.Fill(dTable);
                dataGridView1.DataSource = dTable;
                int row = dataGridView1.CurrentRow.Index;//獲取當前行的索引值
                DataRow dr = dTable.Rows[row];//獲取當前行
                dr.Delete();
                //實現同步更新
                SqlCommandBuilder scb = new SqlCommandBuilder(adapter);
                adapter.Update(dTable);
            }
            //cmd.ExecuteNonQuery();
            //con.Close();



        }
    }
}

