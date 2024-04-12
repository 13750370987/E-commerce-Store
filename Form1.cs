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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ProgramLoad();

        }

        private void ProgramLoad()
        {
            GetInformation();
            
        }


        private void button1_Click(object sender, EventArgs e)
        {

            GetInformation();
        }


        private void dg1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GetDetailByID(e.RowIndex + 1);
        }

        public void GetInformation()
        {
            SQLiteConnection SqliteConnect = new SQLiteConnection("data source=" + SqliteEXE.Path);
            try
            {
                SqliteConnect.Open();
                SQLiteDataAdapter mAdapter = new SQLiteDataAdapter("select * from Product", SqliteConnect);
                DataTable dt = new DataTable();
                mAdapter.Fill(dt);
                dataGridView1.DataSource = dt;
                SqliteConnect.Close();

                dataGridView1.Columns["ProductID"].Visible = false;
                dataGridView1.Columns["ProductName"].HeaderText = "产品分类";
                foreach (DataGridViewColumn column in dataGridView1.Columns) {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }

                GetDetailByID(1);

            }
            catch (Exception ex)
            {
                throw new Exception("搜索产品分类失败，请检测数据库");


            }
        }

        public void GetDetailByID(int ProductID)
        {
            SQLiteConnection SqliteConnect = new SQLiteConnection("data source=" + SqliteEXE.Path);
            try
            {
                dataGridView2.DataSource = null;
                dataGridView2.Columns.Clear();
                SqliteConnect.Open();
                SQLiteDataAdapter mAdapter = new SQLiteDataAdapter("select b.ID, a.ProductName, Supplier, Sell, Mark from Product a join ProductDetail b on a.ProductID = b.ProductID where b.ProductID = " + ProductID , SqliteConnect);
                DataTable dt = new DataTable();
                mAdapter.Fill(dt);
                dataGridView2.DataSource = dt;
                SqliteConnect.Close();

                DataGridViewTextBoxColumn TextBox1 = new DataGridViewTextBoxColumn();
                TextBox1.Name = "Count";
                TextBox1.HeaderText = "购买数量";
                TextBox1.DefaultCellStyle.NullValue = "1";

                DataGridViewButtonColumn btn2 = new DataGridViewButtonColumn();
                btn2.Name = "Cart";
                btn2.HeaderText = "加入购物车";
                btn2.UseColumnTextForButtonValue = true;
                btn2.Text = "加入购物车";

                dataGridView2.Columns.Add(TextBox1);
                dataGridView2.Columns.Insert(dataGridView2.Columns.Count, btn2);


                for (int i = 0; i <= dataGridView2.Columns.Count - 1; i++) {
                    dataGridView2.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }


                dataGridView2.Columns["ProductName"].HeaderText = "产品名称";
                dataGridView2.Columns["Supplier"].HeaderText = "供应商";
                dataGridView2.Columns["Sell"].HeaderText = "价格";
                dataGridView2.Columns["Mark"].HeaderText = "商品详情";
                dataGridView2.Columns["ID"].Visible = true;
                dataGridView2.RowTemplate.Height = 50;



            }
            catch (Exception ex)
            {
                throw new Exception("搜索产品信息失败，请检测数据库");


            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.Columns[e.ColumnIndex].Name == "Cart")
            {
                string int1 = dataGridView2.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                int ID = int.Parse(dataGridView2.Rows[e.RowIndex].Cells["ID"].Value.ToString());
                int Price = int.Parse(dataGridView2.Rows[e.RowIndex].Cells["Sell"].Value.ToString());
                SqliteEXE.InsertIntoCart(ID);
                Sell = Sell + Price;
                CartCount = CartCount + 1;
                UpdateCartCount();



            }
        }

        private void UpdateCartCount()
        {
            this.label5.Text = CartCount.ToString();
            this.label6.Text = Sell.ToString();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            if (CartCount == 0)
            {
                MessageBox.Show("购物车数量为0，请先选择物品");
            }
            else {
                Cart cart = new Cart();
                cart.StartPosition = FormStartPosition.CenterScreen;
                cart.ShowDialog();
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (CartCount == 0)
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

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Main main = new Main();
            this.Hide();
            main.StartPosition = FormStartPosition.CenterScreen;
            main.ShowDialog();
            this.Dispose();


        }



        public static int CartCount = 0;
        public static int Sell = 0;



        private void button4_Click(object sender, EventArgs e)
        {
            SqliteEXE.Clear_Cart();
            this.UpdateCartCount();
    }

        private void Form1_Activated(object sender, EventArgs e)
        {
            this.UpdateCartCount();
        }
    }
    
    
}
