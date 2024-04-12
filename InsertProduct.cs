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
    public partial class InsertProduct : Form
    {
        public InsertProduct()
        {
            InitializeComponent();
            ProgramLoad();

        }

        private void ProgramLoad()
        {
            getProductInfo();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string product2 = this.textBox5.Text.Trim().ToString();
            SqliteEXE.InsertIntoProduct(product2);
            getProductInfo();
            MessageBox.Show("添加成功！");


        }

        private void getProductInfo()
        {

            SQLiteConnection SqliteConnect = new SQLiteConnection("data source=" + SqliteEXE.Path);
            try
            {
                SqliteConnect.Open();
                
                SQLiteDataAdapter mAdapter = new SQLiteDataAdapter("select ProductName from Product ", SqliteConnect);
                DataTable dt = new DataTable();
                mAdapter.Fill(dt);
                
                this.comboBox1.DisplayMember = "ProductName";
                this.comboBox1.ValueMember = "ProductName";
                this.comboBox1.DataSource = dt;
                SqliteConnect.Close();


            }
            catch (Exception ex)
            {
                throw new Exception("搜索产品信息失败，请检查数据库");


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text1 = this.comboBox1.Text.Trim().ToString();
            string text3 = this.textBox2.Text.Trim().ToString();
            string text4 = this.textBox3.Text.Trim().ToString();
            string text5 = this.textBox4.Text.Trim().ToString();
            decimal num = 0;
            
            if (text1.Trim() == "" || text3.Trim() == "" || text4.Trim() == "" || decimal.TryParse(text4, out num))
            {
                SqliteEXE.InsertIntoProductDetail(text1, text3, text4, text5);
            }
            else {
                MessageBox.Show("数据不符合，请重新输入!");
            }

            

        }

    }
}

    
    

