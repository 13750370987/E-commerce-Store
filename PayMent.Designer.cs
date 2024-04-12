using System.Windows.Forms;

namespace WindowsFormsApp1
{
    partial class PayMent
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView3.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView3.Location = new System.Drawing.Point(32, 185);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.RowHeadersWidth = 300;
            this.dataGridView3.RowTemplate.Height = 33;
            this.dataGridView3.Size = new System.Drawing.Size(1072, 1001);
            this.dataGridView3.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15F);
            this.label2.Location = new System.Drawing.Point(46, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 35);
            this.label2.TabIndex = 5;
            this.label2.Text = "将要购买的商品";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 15F);
            this.label3.Location = new System.Drawing.Point(1159, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(295, 35);
            this.label3.TabIndex = 7;
            this.label3.Text = "已选择的商品件数";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 15F);
            this.label4.Location = new System.Drawing.Point(1159, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(295, 35);
            this.label4.TabIndex = 8;
            this.label4.Text = "已选择的商品价格";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 15F);
            this.label5.Location = new System.Drawing.Point(1512, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 35);
            this.label5.TabIndex = 9;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 15F);
            this.label6.Location = new System.Drawing.Point(1512, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 35);
            this.label6.TabIndex = 10;
            this.label6.Text = "label6";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("宋体", 15F);
            this.button3.Location = new System.Drawing.Point(1268, 996);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(287, 161);
            this.button3.TabIndex = 11;
            this.button3.Text = "确认付款";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F);
            this.label1.Location = new System.Drawing.Point(1242, 679);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 35);
            this.label1.TabIndex = 12;
            this.label1.Text = "请输入详细的邮递地址";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1220, 755);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(422, 150);
            this.textBox1.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 15F);
            this.label7.Location = new System.Drawing.Point(1159, 424);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(190, 35);
            this.label7.TabIndex = 14;
            this.label7.Text = "联系电话：";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("宋体", 12F);
            this.textBox2.Location = new System.Drawing.Point(1345, 345);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(327, 39);
            this.textBox2.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 15F);
            this.label8.Location = new System.Drawing.Point(1159, 349);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 35);
            this.label8.TabIndex = 16;
            this.label8.Text = "接收人：";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("宋体", 12F);
            this.textBox3.Location = new System.Drawing.Point(1345, 420);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(327, 39);
            this.textBox3.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 15F);
            this.label9.Location = new System.Drawing.Point(1159, 494);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(190, 35);
            this.label9.TabIndex = 18;
            this.label9.Text = "备用电话：";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("宋体", 12F);
            this.textBox4.Location = new System.Drawing.Point(1345, 497);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(327, 39);
            this.textBox4.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 15F);
            this.label10.Location = new System.Drawing.Point(1159, 569);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(190, 35);
            this.label10.TabIndex = 20;
            this.label10.Text = "邮递地区：";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("宋体", 14F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Singapore",
            "KL"});
            this.comboBox1.Location = new System.Drawing.Point(1345, 563);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(327, 41);
            this.comboBox1.TabIndex = 21;
            // 
            // PayMent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1713, 1227);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView3);
            this.Name = "PayMent";
            this.Text = "Payment";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion
        private System.Windows.Forms.DataGridView dataGridView3;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button3;
        private Label label1;
        private TextBox textBox1;
        private Label label7;
        private TextBox textBox2;
        private Label label8;
        private TextBox textBox3;
        private Label label9;
        private TextBox textBox4;
        private Label label10;
        private ComboBox comboBox1;
    }
}

