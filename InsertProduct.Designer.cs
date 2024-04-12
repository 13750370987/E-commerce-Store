using System.Windows.Forms;

namespace WindowsFormsApp1
{
    partial class InsertProduct
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F);
            this.label1.Location = new System.Drawing.Point(37, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = "产品类型";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15F);
            this.label2.Location = new System.Drawing.Point(72, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 35);
            this.label2.TabIndex = 5;
            this.label2.Text = "供货商";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("宋体", 15F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(251, 70);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(465, 43);
            this.comboBox1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 15F);
            this.label4.Location = new System.Drawing.Point(107, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 35);
            this.label4.TabIndex = 9;
            this.label4.Text = "价格";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 15F);
            this.label5.Location = new System.Drawing.Point(107, 537);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 35);
            this.label5.TabIndex = 10;
            this.label5.Text = "备注";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("宋体", 15F);
            this.textBox2.Location = new System.Drawing.Point(251, 190);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(253, 47);
            this.textBox2.TabIndex = 12;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("宋体", 15F);
            this.textBox3.Location = new System.Drawing.Point(251, 286);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(253, 47);
            this.textBox3.TabIndex = 13;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("宋体", 15F);
            this.textBox4.Location = new System.Drawing.Point(113, 599);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(1290, 258);
            this.textBox4.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 15F);
            this.button1.Location = new System.Drawing.Point(1179, 899);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 55);
            this.button1.TabIndex = 15;
            this.button1.Text = "添加产品";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("宋体", 15F);
            this.button2.Location = new System.Drawing.Point(941, 152);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(367, 55);
            this.button2.TabIndex = 16;
            this.button2.Text = "添加新的产品类型";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 15F);
            this.label6.Location = new System.Drawing.Point(762, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 35);
            this.label6.TabIndex = 17;
            this.label6.Text = "新产品类型";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("宋体", 15F);
            this.textBox5.Location = new System.Drawing.Point(958, 66);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(326, 47);
            this.textBox5.TabIndex = 18;
            // 
            // InsertProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1517, 976);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InsertProduct";
            this.Text = "选购界面";
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion
        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private Label label4;
        private Label label5;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
        private Button button2;
        private Label label6;
        private TextBox textBox5;
    }
}

