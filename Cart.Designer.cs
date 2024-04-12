using System.Windows.Forms;

namespace WindowsFormsApp1
{
    partial class Cart
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToResizeRows = false;
            this.dataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView4.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView4.Location = new System.Drawing.Point(32, 166);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersVisible = false;
            this.dataGridView4.RowHeadersWidth = 300;
            this.dataGridView4.RowTemplate.Height = 33;
            this.dataGridView4.Size = new System.Drawing.Size(1072, 1001);
            this.dataGridView4.TabIndex = 3;
            this.dataGridView4.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15F);
            this.label2.Location = new System.Drawing.Point(47, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 35);
            this.label2.TabIndex = 5;
            this.label2.Text = "将要购买的商品";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 15F);
            this.label3.Location = new System.Drawing.Point(1186, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(295, 35);
            this.label3.TabIndex = 7;
            this.label3.Text = "已选择的商品件数";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 15F);
            this.label4.Location = new System.Drawing.Point(1186, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(295, 35);
            this.label4.TabIndex = 8;
            this.label4.Text = "已选择的商品价格";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 20F);
            this.label5.Location = new System.Drawing.Point(1548, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 47);
            this.label5.TabIndex = 9;
            this.label5.Text = "0";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 20F);
            this.label6.Location = new System.Drawing.Point(1548, 340);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 47);
            this.label6.TabIndex = 10;
            this.label6.Text = "0";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("宋体", 12F);
            this.button4.Location = new System.Drawing.Point(1285, 667);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(278, 94);
            this.button4.TabIndex = 13;
            this.button4.Text = "清空购物车";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.Font = new System.Drawing.Font("宋体", 13F);
            this.button1.Location = new System.Drawing.Point(1192, 1050);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(456, 94);
            this.button1.TabIndex = 14;
            this.button1.Text = "确认并付款";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1713, 1227);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView4);
            this.Name = "Cart";
            this.Text = "Cart";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion
        private System.Windows.Forms.DataGridView dataGridView4;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button4;
        private Button button1;
    }
}

