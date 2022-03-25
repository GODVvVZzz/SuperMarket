namespace SuperMarket.UI
{
    partial class UFrmDqkc
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_RefreshStock = new CCWin.SkinControl.SkinButton();
            this.btn_Replenishment = new CCWin.SkinControl.SkinButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(4, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "以下商品为当前库存量小于当前商品最小数量的商品";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 104);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1090, 562);
            this.dataGridView1.TabIndex = 9;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_RefreshStock
            // 
            this.btn_RefreshStock.BackColor = System.Drawing.Color.Transparent;
            this.btn_RefreshStock.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_RefreshStock.DownBack = null;
            this.btn_RefreshStock.Location = new System.Drawing.Point(899, 26);
            this.btn_RefreshStock.MouseBack = null;
            this.btn_RefreshStock.Name = "btn_RefreshStock";
            this.btn_RefreshStock.NormlBack = null;
            this.btn_RefreshStock.Size = new System.Drawing.Size(117, 33);
            this.btn_RefreshStock.TabIndex = 10;
            this.btn_RefreshStock.Text = "刷新库存";
            this.btn_RefreshStock.UseVisualStyleBackColor = false;
            this.btn_RefreshStock.Click += new System.EventHandler(this.btn_RefreshStock_Click);
            // 
            // btn_Replenishment
            // 
            this.btn_Replenishment.BackColor = System.Drawing.Color.Transparent;
            this.btn_Replenishment.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_Replenishment.DownBack = null;
            this.btn_Replenishment.Location = new System.Drawing.Point(737, 26);
            this.btn_Replenishment.MouseBack = null;
            this.btn_Replenishment.Name = "btn_Replenishment";
            this.btn_Replenishment.NormlBack = null;
            this.btn_Replenishment.Size = new System.Drawing.Size(117, 33);
            this.btn_Replenishment.TabIndex = 11;
            this.btn_Replenishment.Text = "补货";
            this.btn_Replenishment.UseVisualStyleBackColor = false;
            this.btn_Replenishment.Click += new System.EventHandler(this.btn_Replenishment_Click);
            // 
            // UFrmDqkc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Replenishment);
            this.Controls.Add(this.btn_RefreshStock);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "UFrmDqkc";
            this.Size = new System.Drawing.Size(1090, 678);
            this.Load += new System.EventHandler(this.UFrmDqkc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Timer timer1;
        private CCWin.SkinControl.SkinButton btn_RefreshStock;
        private CCWin.SkinControl.SkinButton btn_Replenishment;
    }
}
