namespace SuperMarket.UI
{
    partial class FrmNEGoods
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNEGoods));
            this.btn_AddCategory = new System.Windows.Forms.Button();
            this.btn_MoreSupplier = new System.Windows.Forms.Button();
            this.lab_GNotes = new System.Windows.Forms.Label();
            this.lab_GSupplier = new System.Windows.Forms.Label();
            this.lab_GUnit = new System.Windows.Forms.Label();
            this.lab_GBid = new System.Windows.Forms.Label();
            this.lab_GPrice = new System.Windows.Forms.Label();
            this.lab_GCID = new System.Windows.Forms.Label();
            this.lab_GName = new System.Windows.Forms.Label();
            this.lab_GID = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.richtxtbox_GNotes = new System.Windows.Forms.RichTextBox();
            this.cmbox_GUnit = new System.Windows.Forms.ComboBox();
            this.txtbox_GSupplier = new System.Windows.Forms.TextBox();
            this.txtbox_GBid = new System.Windows.Forms.TextBox();
            this.txtbox_GPrice = new System.Windows.Forms.TextBox();
            this.cmbox_GCID = new System.Windows.Forms.ComboBox();
            this.txtbox_GName = new System.Windows.Forms.TextBox();
            this.txtbox_GID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_AddCategory
            // 
            this.btn_AddCategory.Location = new System.Drawing.Point(287, 88);
            this.btn_AddCategory.Margin = new System.Windows.Forms.Padding(4);
            this.btn_AddCategory.Name = "btn_AddCategory";
            this.btn_AddCategory.Size = new System.Drawing.Size(28, 26);
            this.btn_AddCategory.TabIndex = 42;
            this.btn_AddCategory.Text = "+";
            this.btn_AddCategory.UseVisualStyleBackColor = true;
            this.btn_AddCategory.Click += new System.EventHandler(this.btn_AddCategory_Click);
            // 
            // btn_MoreSupplier
            // 
            this.btn_MoreSupplier.Location = new System.Drawing.Point(287, 223);
            this.btn_MoreSupplier.Margin = new System.Windows.Forms.Padding(4);
            this.btn_MoreSupplier.Name = "btn_MoreSupplier";
            this.btn_MoreSupplier.Size = new System.Drawing.Size(41, 25);
            this.btn_MoreSupplier.TabIndex = 41;
            this.btn_MoreSupplier.Text = "...";
            this.btn_MoreSupplier.UseVisualStyleBackColor = true;
            this.btn_MoreSupplier.Click += new System.EventHandler(this.btn_MoreSupplier_Click);
            // 
            // lab_GNotes
            // 
            this.lab_GNotes.AutoSize = true;
            this.lab_GNotes.Location = new System.Drawing.Point(24, 259);
            this.lab_GNotes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_GNotes.Name = "lab_GNotes";
            this.lab_GNotes.Size = new System.Drawing.Size(84, 15);
            this.lab_GNotes.TabIndex = 40;
            this.lab_GNotes.Text = "备    注：";
            // 
            // lab_GSupplier
            // 
            this.lab_GSupplier.AutoSize = true;
            this.lab_GSupplier.Location = new System.Drawing.Point(24, 226);
            this.lab_GSupplier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_GSupplier.Name = "lab_GSupplier";
            this.lab_GSupplier.Size = new System.Drawing.Size(83, 15);
            this.lab_GSupplier.TabIndex = 39;
            this.lab_GSupplier.Text = "供 应 商：";
            // 
            // lab_GUnit
            // 
            this.lab_GUnit.AutoSize = true;
            this.lab_GUnit.Location = new System.Drawing.Point(24, 193);
            this.lab_GUnit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_GUnit.Name = "lab_GUnit";
            this.lab_GUnit.Size = new System.Drawing.Size(84, 15);
            this.lab_GUnit.TabIndex = 38;
            this.lab_GUnit.Text = "单    位：";
            // 
            // lab_GBid
            // 
            this.lab_GBid.AutoSize = true;
            this.lab_GBid.Location = new System.Drawing.Point(24, 159);
            this.lab_GBid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_GBid.Name = "lab_GBid";
            this.lab_GBid.Size = new System.Drawing.Size(84, 15);
            this.lab_GBid.TabIndex = 37;
            this.lab_GBid.Text = "进    价：";
            // 
            // lab_GPrice
            // 
            this.lab_GPrice.AutoSize = true;
            this.lab_GPrice.Location = new System.Drawing.Point(24, 126);
            this.lab_GPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_GPrice.Name = "lab_GPrice";
            this.lab_GPrice.Size = new System.Drawing.Size(84, 15);
            this.lab_GPrice.TabIndex = 36;
            this.lab_GPrice.Text = "售    价：";
            // 
            // lab_GCID
            // 
            this.lab_GCID.AutoSize = true;
            this.lab_GCID.Location = new System.Drawing.Point(24, 93);
            this.lab_GCID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_GCID.Name = "lab_GCID";
            this.lab_GCID.Size = new System.Drawing.Size(84, 15);
            this.lab_GCID.TabIndex = 35;
            this.lab_GCID.Text = "类    别：";
            // 
            // lab_GName
            // 
            this.lab_GName.AutoSize = true;
            this.lab_GName.Location = new System.Drawing.Point(24, 59);
            this.lab_GName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_GName.Name = "lab_GName";
            this.lab_GName.Size = new System.Drawing.Size(82, 15);
            this.lab_GName.TabIndex = 34;
            this.lab_GName.Text = "商品名称：";
            // 
            // lab_GID
            // 
            this.lab_GID.AutoSize = true;
            this.lab_GID.Location = new System.Drawing.Point(24, 24);
            this.lab_GID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_GID.Name = "lab_GID";
            this.lab_GID.Size = new System.Drawing.Size(82, 15);
            this.lab_GID.TabIndex = 33;
            this.lab_GID.Text = "商品编号：";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(208, 343);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(100, 29);
            this.btn_Cancel.TabIndex = 32;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(74, 343);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(100, 29);
            this.btn_Save.TabIndex = 31;
            this.btn_Save.Text = "保存";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // richtxtbox_GNotes
            // 
            this.richtxtbox_GNotes.Location = new System.Drawing.Point(119, 256);
            this.richtxtbox_GNotes.Margin = new System.Windows.Forms.Padding(4);
            this.richtxtbox_GNotes.Name = "richtxtbox_GNotes";
            this.richtxtbox_GNotes.Size = new System.Drawing.Size(265, 74);
            this.richtxtbox_GNotes.TabIndex = 30;
            this.richtxtbox_GNotes.Text = "";
            // 
            // cmbox_GUnit
            // 
            this.cmbox_GUnit.FormattingEnabled = true;
            this.cmbox_GUnit.Items.AddRange(new object[] {
            "盒",
            "箱",
            "瓶",
            "桶",
            "袋",
            "台",
            "包",
            "只",
            "斤"});
            this.cmbox_GUnit.Location = new System.Drawing.Point(119, 189);
            this.cmbox_GUnit.Margin = new System.Windows.Forms.Padding(4);
            this.cmbox_GUnit.Name = "cmbox_GUnit";
            this.cmbox_GUnit.Size = new System.Drawing.Size(159, 23);
            this.cmbox_GUnit.TabIndex = 29;
            // 
            // txtbox_GSupplier
            // 
            this.txtbox_GSupplier.Location = new System.Drawing.Point(119, 222);
            this.txtbox_GSupplier.Margin = new System.Windows.Forms.Padding(4);
            this.txtbox_GSupplier.Name = "txtbox_GSupplier";
            this.txtbox_GSupplier.ReadOnly = true;
            this.txtbox_GSupplier.Size = new System.Drawing.Size(159, 25);
            this.txtbox_GSupplier.TabIndex = 28;
            // 
            // txtbox_GBid
            // 
            this.txtbox_GBid.Location = new System.Drawing.Point(119, 156);
            this.txtbox_GBid.Margin = new System.Windows.Forms.Padding(4);
            this.txtbox_GBid.Name = "txtbox_GBid";
            this.txtbox_GBid.Size = new System.Drawing.Size(159, 25);
            this.txtbox_GBid.TabIndex = 27;
            // 
            // txtbox_GPrice
            // 
            this.txtbox_GPrice.Location = new System.Drawing.Point(119, 122);
            this.txtbox_GPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtbox_GPrice.Name = "txtbox_GPrice";
            this.txtbox_GPrice.Size = new System.Drawing.Size(159, 25);
            this.txtbox_GPrice.TabIndex = 26;
            // 
            // cmbox_GCID
            // 
            this.cmbox_GCID.FormattingEnabled = true;
            this.cmbox_GCID.Items.AddRange(new object[] {
            "食品饮料",
            "粮油副食",
            "美容洗护",
            "家电",
            "家庭清洁",
            "生鲜水果"});
            this.cmbox_GCID.Location = new System.Drawing.Point(119, 89);
            this.cmbox_GCID.Margin = new System.Windows.Forms.Padding(4);
            this.cmbox_GCID.Name = "cmbox_GCID";
            this.cmbox_GCID.Size = new System.Drawing.Size(159, 23);
            this.cmbox_GCID.TabIndex = 25;
            // 
            // txtbox_GName
            // 
            this.txtbox_GName.Location = new System.Drawing.Point(119, 56);
            this.txtbox_GName.Margin = new System.Windows.Forms.Padding(4);
            this.txtbox_GName.Name = "txtbox_GName";
            this.txtbox_GName.Size = new System.Drawing.Size(159, 25);
            this.txtbox_GName.TabIndex = 24;
            // 
            // txtbox_GID
            // 
            this.txtbox_GID.Location = new System.Drawing.Point(119, 20);
            this.txtbox_GID.Margin = new System.Windows.Forms.Padding(4);
            this.txtbox_GID.Name = "txtbox_GID";
            this.txtbox_GID.ReadOnly = true;
            this.txtbox_GID.Size = new System.Drawing.Size(159, 25);
            this.txtbox_GID.TabIndex = 23;
            // 
            // FrmNEGoods
            // 
            this.AcceptButton = this.btn_Save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 393);
            this.Controls.Add(this.btn_AddCategory);
            this.Controls.Add(this.btn_MoreSupplier);
            this.Controls.Add(this.lab_GNotes);
            this.Controls.Add(this.lab_GSupplier);
            this.Controls.Add(this.lab_GUnit);
            this.Controls.Add(this.lab_GBid);
            this.Controls.Add(this.lab_GPrice);
            this.Controls.Add(this.lab_GCID);
            this.Controls.Add(this.lab_GName);
            this.Controls.Add(this.lab_GID);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.richtxtbox_GNotes);
            this.Controls.Add(this.cmbox_GUnit);
            this.Controls.Add(this.txtbox_GSupplier);
            this.Controls.Add(this.txtbox_GBid);
            this.Controls.Add(this.txtbox_GPrice);
            this.Controls.Add(this.cmbox_GCID);
            this.Controls.Add(this.txtbox_GName);
            this.Controls.Add(this.txtbox_GID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmNEGoods";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmNEGoods_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_AddCategory;
        private System.Windows.Forms.Button btn_MoreSupplier;
        private System.Windows.Forms.Label lab_GNotes;
        private System.Windows.Forms.Label lab_GSupplier;
        private System.Windows.Forms.Label lab_GUnit;
        private System.Windows.Forms.Label lab_GBid;
        private System.Windows.Forms.Label lab_GPrice;
        private System.Windows.Forms.Label lab_GCID;
        private System.Windows.Forms.Label lab_GName;
        private System.Windows.Forms.Label lab_GID;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.RichTextBox richtxtbox_GNotes;
        private System.Windows.Forms.ComboBox cmbox_GUnit;
        private System.Windows.Forms.TextBox txtbox_GSupplier;
        private System.Windows.Forms.TextBox txtbox_GBid;
        private System.Windows.Forms.TextBox txtbox_GPrice;
        private System.Windows.Forms.ComboBox cmbox_GCID;
        private System.Windows.Forms.TextBox txtbox_GName;
        private System.Windows.Forms.TextBox txtbox_GID;
    }
}