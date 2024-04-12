using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using System.Linq.Expressions;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;

namespace WindowsFormsApp1
{
    public partial class PayMent : Form
    {
        public PayMent()
        {
            InitializeComponent();
            GetInformation();
            


        }


        public void GetInformation()
        {
            SQLiteConnection SqliteConnect = new SQLiteConnection("data source=" + SqliteEXE.Path);
            try
            {
                dataGridView3.DataSource = null;
                dataGridView3.Columns.Clear();
                SqliteConnect.Open();
                SQLiteDataAdapter mAdapter = new SQLiteDataAdapter("select ROW_NUMBER() OVER(ORDER BY c.CartID) AS RowNumber, c.CartID, b.ID, a.ProductName, Supplier, Sell, Mark from Product a join ProductDetail b on a.ProductID = b.ProductID inner join Cart c on b.ID = c.productDetailID ", SqliteConnect);
                DataTable dt = new DataTable();
                mAdapter.Fill(dt);
                dataGridView3.DataSource = dt;
                SqliteConnect.Close();

                dataGridView3.Columns["RowNumber"].HeaderText = "ID";
                dataGridView3.Columns["ProductName"].HeaderText = "商品名称";
                dataGridView3.Columns["Supplier"].HeaderText = "供应商";
                dataGridView3.Columns["Sell"].HeaderText = "价格";
                dataGridView3.Columns["Mark"].HeaderText = "商品详情";
                dataGridView3.Columns["CartID"].Visible = false;
                dataGridView3.Columns["ID"].Visible = false;
                dataGridView3.RowTemplate.Height = 50;

            }
            catch (Exception ex)
            {
                throw new Exception("搜索购物车失败，请检测数据库");


            }

            this.label5.Text = Form1.CartCount.ToString();
            this.label6.Text = Form1.Sell.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool Payment = true;
            for (int i = 0; i <= dataGridView3.Rows.Count - 1; i++) {
                string id1 = dataGridView3.Rows[i].Cells["ID"].Value.ToString();
                string name = this.textBox2.Text.Trim().ToString();
                string phone1 = this.textBox3.Text.Trim().ToString();
                string phone2 = this.textBox4.Text.Trim().ToString();
                string Address = this.textBox1.Text.Trim().ToString();
                string Country = this.comboBox1.Text.Trim().ToString();
                int num = 0;
                int num1 = 0;
                if (i == 0 && Payment) { 

                if (!(name.Trim() != "" && int.TryParse(phone1, out num) && (int.TryParse(phone2, out num1) || phone2 == "") && Address.Trim() != "" && Country.Trim() != ""))
                {
                        MessageBox.Show("信息输入错误，请检查!");
                        Payment = false;
                        break;
                }

                }

                SqliteEXE.insertintoRecord(id1, name, phone1, phone2, Address, Country);
            }

            if (Payment) {
                MessageBox.Show("你已成功付款！");
                SqliteEXE.Clear_Cart();
                this.Dispose();
                

            }

            
        }
    }
}
