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
    public partial class ControlPanel : Form
    {
        public ControlPanel()
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
            Control control = new Control();
            control.StartPosition = FormStartPosition.CenterScreen;
            control.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Record control = new Record();
            control.StartPosition = FormStartPosition.CenterScreen;
            control.ShowDialog();
        }
    }
}
