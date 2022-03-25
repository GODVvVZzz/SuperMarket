namespace SuperMarket.UI
{
    partial class UFrmLsjyjl
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radbtn_cmbox = new System.Windows.Forms.RadioButton();
            this.radbtn_All = new System.Windows.Forms.RadioButton();
            this.cmbox_OrderNum = new System.Windows.Forms.ComboBox();
            this.lab_OrderNum = new System.Windows.Forms.Label();
            this.dataGridView1 = new CCWin.SkinControl.SkinDataGridView();
            this.btn_Search = new CCWin.SkinControl.SkinButton();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1090, 179);
            this.panel2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radbtn_cmbox);
            this.panel1.Controls.Add(this.btn_Search);
            this.panel1.Controls.Add(this.radbtn_All);
            this.panel1.Controls.Add(this.cmbox_OrderNum);
            this.panel1.Controls.Add(this.lab_OrderNum);
            this.panel1.Location = new System.Drawing.Point(49, 25);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 125);
            this.panel1.TabIndex = 8;
            // 
            // radbtn_cmbox
            // 
            this.radbtn_cmbox.AutoSize = true;
            this.radbtn_cmbox.Location = new System.Drawing.Point(128, 30);
            this.radbtn_cmbox.Margin = new System.Windows.Forms.Padding(4);
            this.radbtn_cmbox.Name = "radbtn_cmbox";
            this.radbtn_cmbox.Size = new System.Drawing.Size(17, 16);
            this.radbtn_cmbox.TabIndex = 6;
            this.radbtn_cmbox.TabStop = true;
            this.radbtn_cmbox.UseVisualStyleBackColor = true;
            // 
            // radbtn_All
            // 
            this.radbtn_All.AutoSize = true;
            this.radbtn_All.Checked = true;
            this.radbtn_All.Location = new System.Drawing.Point(128, 75);
            this.radbtn_All.Margin = new System.Windows.Forms.Padding(4);
            this.radbtn_All.Name = "radbtn_All";
            this.radbtn_All.Size = new System.Drawing.Size(58, 19);
            this.radbtn_All.TabIndex = 7;
            this.radbtn_All.TabStop = true;
            this.radbtn_All.Text = "全部";
            this.radbtn_All.UseVisualStyleBackColor = true;
            // 
            // cmbox_OrderNum
            // 
            this.cmbox_OrderNum.FormattingEnabled = true;
            this.cmbox_OrderNum.Location = new System.Drawing.Point(155, 26);
            this.cmbox_OrderNum.Margin = new System.Windows.Forms.Padding(4);
            this.cmbox_OrderNum.Name = "cmbox_OrderNum";
            this.cmbox_OrderNum.Size = new System.Drawing.Size(172, 23);
            this.cmbox_OrderNum.TabIndex = 8;
            this.cmbox_OrderNum.Click += new System.EventHandler(this.cmbox_OrderNum_Click);
            // 
            // lab_OrderNum
            // 
            this.lab_OrderNum.AutoSize = true;
            this.lab_OrderNum.Location = new System.Drawing.Point(33, 30);
            this.lab_OrderNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_OrderNum.Name = "lab_OrderNum";
            this.lab_OrderNum.Size = new System.Drawing.Size(82, 15);
            this.lab_OrderNum.TabIndex = 9;
            this.lab_OrderNum.Text = "订单编号：";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnFont = null;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnSelectForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.HeadFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dataGridView1.HeadSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView1.Location = new System.Drawing.Point(2, 181);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1087, 500);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.TitleBack = null;
            this.dataGridView1.TitleBackColorBegin = System.Drawing.Color.White;
            this.dataGridView1.TitleBackColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(196)))), ((int)(((byte)(242)))));
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.Transparent;
            this.btn_Search.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_Search.DownBack = null;
            this.btn_Search.Location = new System.Drawing.Point(228, 71);
            this.btn_Search.MouseBack = null;
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.NormlBack = null;
            this.btn_Search.Size = new System.Drawing.Size(100, 29);
            this.btn_Search.TabIndex = 14;
            this.btn_Search.Text = "查询";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // UFrmLsjyjl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Name = "UFrmLsjyjl";
            this.Size = new System.Drawing.Size(1090, 678);
            this.Load += new System.EventHandler(this.UFrmLsjyjl_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radbtn_cmbox;
        private System.Windows.Forms.RadioButton radbtn_All;
        private System.Windows.Forms.ComboBox cmbox_OrderNum;
        private System.Windows.Forms.Label lab_OrderNum;
        private CCWin.SkinControl.SkinDataGridView dataGridView1;
        private CCWin.SkinControl.SkinButton btn_Search;
    }
}
