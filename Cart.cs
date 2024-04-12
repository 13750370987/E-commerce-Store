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
using System.Diagnostics;

namespace WindowsFormsApp1
{
    public partial class Cart : Form
    {
        public Cart()
        {
            InitializeComponent();
            CartLoad();
        }

        public void CartLoad()
        {
            FindCartInformation();

            this.label5.Text = Form1.CartCount.ToString();
            this.label6.Text = Form1.Sell.ToString();

        }

        private void FindCartInformation()
        {

            SQLiteConnection SqliteConnect = new SQLiteConnection("data source=" + SqliteEXE.Path);
            try
            {
                dataGridView4.DataSource = null;
                dataGridView4.Columns.Clear();
                SqliteConnect.Open();
                SQLiteDataAdapter mAdapter = new SQLiteDataAdapter("select ROW_NUMBER() OVER(ORDER BY c.CartID) AS RowNumber, c.CartID, a.ProductName, Supplier, Sell, Mark from Product a join ProductDetail b on a.ProductID = b.ProductID inner join Cart c on b.ID = c.productDetailID ", SqliteConnect);
                DataTable dt = new DataTable();
                mAdapter.Fill(dt);
                dataGridView4.DataSource = dt;
                SqliteConnect.Close();

                dataGridView4.Columns["RowNumber"].HeaderText = "ID";
                dataGridView4.Columns["ProductName"].HeaderText = "商品名称";
                dataGridView4.Columns["Supplier"].HeaderText = "供应商";
                dataGridView4.Columns["Sell"].HeaderText = "价格";
                dataGridView4.Columns["Mark"].HeaderText = "商品详情";
                dataGridView4.Columns["CartID"].Visible = false;

                DataGridViewButtonColumn btn3 = new DataGridViewButtonColumn();
                btn3.Name = "DeleteOneCart";
                btn3.HeaderText = "从购物车移去";
                btn3.UseColumnTextForButtonValue = true;
                btn3.Text = "从购物车移去";

                dataGridView4.Columns.Insert(dataGridView4.Columns.Count, btn3);
                dataGridView4.RowTemplate.Height = 50;

            }
            catch (Exception ex)
            {
                throw new Exception("搜索购物车失败，请检测数据库");


            }

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView4.Columns[e.ColumnIndex].Name == "DeleteOneCart")
            {
                string int1 = dataGridView4.Rows[e.RowIndex].Cells["CartID"].Value.ToString();
                int ID = int.Parse(dataGridView4.Rows[e.RowIndex].Cells["CartID"].Value.ToString());
                int Price = int.Parse(dataGridView4.Rows[e.RowIndex].Cells["Sell"].Value.ToString());
                SqliteEXE.DeleteIntoCart(ID);

                Form1.Sell = Form1.Sell - Price;
                Form1.CartCount = Form1.CartCount - 1;

                this.label5.Text = Form1.CartCount.ToString();
                this.label6.Text = Form1.Sell.ToString();

                FindCartInformation();



            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqliteEXE.Clear_Cart();
            this.label5.Text = Form1.CartCount.ToString();
            this.label6.Text = Form1.Sell.ToString();
            dataGridView4.DataSource = null;
            dataGridView4.Columns.Clear();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Form1.CartCount == 0)
            {
                MessageBox.Show("购物车数量为0，请先选择物品");
            }
            else
            {

                var result1 = MessageBox.Show("以下物品只可邮递到 Singapore 和 LK，是否继续？", "邮递提示", MessageBoxButtons.YesNoCancel);
                if (result1 == DialogResult.Yes)
                {
                    PayMent payment = new PayMent();
                    payment.StartPosition = FormStartPosition.CenterScreen;
                    payment.ShowDialog();

                }
            }
        }
    }
}
