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
    public partial class Record : Form
    {
        public Record()
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
                SQLiteDataAdapter mAdapter = new SQLiteDataAdapter("select ROW_NUMBER() OVER(ORDER BY c.RecordID) AS RowNumber, a.ProductName, b.Supplier, b.Sell, c.Name, c.Phone1, c.country  from Product a join ProductDetail b on a.ProductID = b.ProductID inner join Record c on b.ID = c.ProductDetailID", SqliteConnect);
                DataTable dt = new DataTable();
                mAdapter.Fill(dt);
                dataGridView3.DataSource = dt;
                SqliteConnect.Close();

                dataGridView3.Columns["RowNumber"].HeaderText = "ID";
                dataGridView3.Columns["ProductName"].HeaderText = "商品名称";
                dataGridView3.Columns["Supplier"].HeaderText = "供应商";
                dataGridView3.Columns["Sell"].HeaderText = "价格";
                dataGridView3.Columns["Name"].HeaderText = "付款人";
                dataGridView3.Columns["Phone1"].HeaderText = "电话";
                dataGridView3.Columns["Country"].HeaderText = "国家";

                dataGridView3.RowTemplate.Height = 50;

            }
            catch (Exception ex)
            {
                throw new Exception("搜索记录，请检测数据库");


            }

            this.label5.Text = dataGridView3.Rows.Count.ToString();
            decimal Sell = 0;
            for (int i = 0; i < dataGridView3.Rows.Count; i++)
            {
                Sell = Sell + Convert.ToDecimal(dataGridView3.Rows[i].Cells["Sell"].Value.ToString());

            }
            this.label6.Text = Sell.ToString();
        }


    }
}
