namespace SuperMarket.UI
{
    partial class UFrmXsph
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
            this.lab_EID = new System.Windows.Forms.Label();
            this.cmbox_EID = new System.Windows.Forms.ComboBox();
            this.btn_Search = new CCWin.SkinControl.SkinButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lab_EID
            // 
            this.lab_EID.AutoSize = true;
            this.lab_EID.Location = new System.Drawing.Point(17, 18);
            this.lab_EID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_EID.Name = "lab_EID";
            this.lab_EID.Size = new System.Drawing.Size(82, 15);
            this.lab_EID.TabIndex = 11;
            this.lab_EID.Text = "员工编号：";
            // 
            // cmbox_EID
            // 
            this.cmbox_EID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbox_EID.FormattingEnabled = true;
            this.cmbox_EID.Location = new System.Drawing.Point(112, 14);
            this.cmbox_EID.Margin = new System.Windows.Forms.Padding(4);
            this.cmbox_EID.Name = "cmbox_EID";
            this.cmbox_EID.Size = new System.Drawing.Size(172, 23);
            this.cmbox_EID.TabIndex = 9;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.Transparent;
            this.btn_Search.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_Search.DownBack = null;
            this.btn_Search.Location = new System.Drawing.Point(301, 9);
            this.btn_Search.MouseBack = null;
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.NormlBack = null;
            this.btn_Search.Size = new System.Drawing.Size(117, 33);
            this.btn_Search.TabIndex = 12;
            this.btn_Search.Text = "查询";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 64);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1082, 614);
            this.dataGridView1.TabIndex = 13;
            // 
            // UFrmXsph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.lab_EID);
            this.Controls.Add(this.cmbox_EID);
            this.Name = "UFrmXsph";
            this.Size = new System.Drawing.Size(1090, 678);
            this.Load += new System.EventHandler(this.UFrmXsph_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_EID;
        private System.Windows.Forms.ComboBox cmbox_EID;
        private CCWin.SkinControl.SkinButton btn_Search;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
