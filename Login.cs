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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();


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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Account = this.textBox1.Text.ToString();
            string Password = this.textBox2.Text.ToString();

            if (Account == "123" && Password == "123")
            {
                this.Dispose();
                ControlPanel controlPanel = new ControlPanel();
                controlPanel.StartPosition = FormStartPosition.CenterScreen;
                controlPanel.ShowDialog();

            }
            else {
                MessageBox.Show("密码输入错误。");
            }



        }
    }
}
