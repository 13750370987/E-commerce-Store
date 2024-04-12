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
    public partial class Control : Form
    {
        public Control()
        {
            InitializeComponent();
            ProgramLoad();

        }

        private void ProgramLoad()
        {


            Create_Database();
            GetInformation();
            
        }
        private void Create_Database()
        {

            if (!File.Exists("./test.db"))
            {
                try
                {
                    //添加数据库

                    string path = SqliteEXE.CreateDB("test");

                }
                catch (Exception ex)
                {

                    throw new Exception("没有找到数据库且,创建数据库失败");

                }
            }
            else
            {
                SqliteEXE.Path = "./test.db";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            GetInformation();
        }


        private void dg1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index1 = e.RowIndex + 1;
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
                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
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


                DataGridViewButtonColumn btn2 = new DataGridViewButtonColumn();
                btn2.Name = "Delete";
                btn2.HeaderText = "移去商品";
                btn2.UseColumnTextForButtonValue = true;
                btn2.Text = "移去商品";

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
            if (dataGridView2.Columns[e.ColumnIndex].Name == "Delete")
            {
                string int1 = dataGridView2.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                int ID = int.Parse(dataGridView2.Rows[e.RowIndex].Cells["ID"].Value.ToString());
                SqliteEXE.DeleteIntoProduct(ID);
                GetDetailByID(index1);
                MessageBox.Show("移去成功!");


            }
        }

        


        private void button3_Click(object sender, EventArgs e)
        {
            InsertProduct insertproduct = new InsertProduct();
            this.Hide();
            insertproduct.StartPosition = FormStartPosition.CenterScreen;
            insertproduct.ShowDialog();
            this.Dispose();
        }




        public static int index1 = 1;



    }
    
    
}
