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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            Create_Database();

        }

        private void Create_Database()
        {

            if (!File.Exists("./test.db"))
            {
                MessageBox.Show("检测到没有数据库，创建初始数据库");
                try
                {
                    //添加数据库

                    string path = SqliteEXE.CreateDB("test");
                    MessageBox.Show("创建初始数据库成功");

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

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            SqliteEXE.Clear_Cart();
            this.Hide();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
            this.Dispose();
             
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.StartPosition = FormStartPosition.CenterScreen;
            login.ShowDialog();


        }
    }
}
