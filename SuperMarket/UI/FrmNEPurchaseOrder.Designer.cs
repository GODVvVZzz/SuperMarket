namespace SuperMarket.UI
{
    partial class FrmNEPurchaseOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNEPurchaseOrder));
            this.cmbox_POGShelfLife_MonthDay = new System.Windows.Forms.ComboBox();
            this.btn_AddPOGCID = new System.Windows.Forms.Button();
            this.btn_MorePOGID = new System.Windows.Forms.Button();
            this.btn_MorePOGSupplier = new System.Windows.Forms.Button();
            this.lab_POGNotes = new System.Windows.Forms.Label();
            this.lab_POGProductionDate = new System.Windows.Forms.Label();
            this.lab_POGShelfLife = new System.Windows.Forms.Label();
            this.lab_POGMinimumInventory = new System.Windows.Forms.Label();
            this.lab_POAmount = new System.Windows.Forms.Label();
            this.lab_POGPrice = new System.Windows.Forms.Label();
            this.lab_POGBid = new System.Windows.Forms.Label();
            this.lab_POGUnit = new System.Windows.Forms.Label();
            this.lab_POGCID = new System.Windows.Forms.Label();
            this.lab_POGName = new System.Windows.Forms.Label();
            this.lab_POGID = new System.Windows.Forms.Label();
            this.lab_PODate = new System.Windows.Forms.Label();
            this.lab_POGSupplier = new System.Windows.Forms.Label();
            this.lab_POID = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.richtxtbox_POGNotes = new System.Windows.Forms.RichTextBox();
            this.dtp_POGProductionDate = new System.Windows.Forms.DateTimePicker();
            this.txtbox_POGShelfLife_MonthDay = new System.Windows.Forms.TextBox();
            this.txtbox_POGMinimumInventory = new System.Windows.Forms.TextBox();
            this.txtbox_POAmount = new System.Windows.Forms.TextBox();
            this.txtbox_POGPrice = new System.Windows.Forms.TextBox();
            this.txtbox_POGBid = new System.Windows.Forms.TextBox();
            this.cmbox_POGUnit = new System.Windows.Forms.ComboBox();
            this.cmbox_POGCID = new System.Windows.Forms.ComboBox();
            this.txtbox_POGName = new System.Windows.Forms.TextBox();
            this.txtbox_POGID = new System.Windows.Forms.TextBox();
            this.dtp_PODate = new System.Windows.Forms.DateTimePicker();
            this.txtbox_POGSupplier = new System.Windows.Forms.TextBox();
            this.txtbox_POID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbox_POGShelfLife_MonthDay
            // 
            this.cmbox_POGShelfLife_MonthDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbox_POGShelfLife_MonthDay.FormattingEnabled = true;
            this.cmbox_POGShelfLife_MonthDay.Items.AddRange(new object[] {
            "个月",
            "天"});
            this.cmbox_POGShelfLife_MonthDay.Location = new System.Drawing.Point(174, 292);
            this.cmbox_POGShelfLife_MonthDay.Margin = new System.Windows.Forms.Padding(4);
            this.cmbox_POGShelfLife_MonthDay.Name = "cmbox_POGShelfLife_MonthDay";
            this.cmbox_POGShelfLife_MonthDay.Size = new System.Drawing.Size(76, 23);
            this.cmbox_POGShelfLife_MonthDay.TabIndex = 70;
            // 
            // btn_AddPOGCID
            // 
            this.btn_AddPOGCID.Location = new System.Drawing.Point(260, 188);
            this.btn_AddPOGCID.Margin = new System.Windows.Forms.Padding(4);
            this.btn_AddPOGCID.Name = "btn_AddPOGCID";
            this.btn_AddPOGCID.Size = new System.Drawing.Size(33, 26);
            this.btn_AddPOGCID.TabIndex = 69;
            this.btn_AddPOGCID.Text = "+";
            this.btn_AddPOGCID.UseVisualStyleBackColor = true;
            this.btn_AddPOGCID.Click += new System.EventHandler(this.btn_AddPOGCID_Click);
            // 
            // btn_MorePOGID
            // 
            this.btn_MorePOGID.Location = new System.Drawing.Point(300, 120);
            this.btn_MorePOGID.Margin = new System.Windows.Forms.Padding(4);
            this.btn_MorePOGID.Name = "btn_MorePOGID";
            this.btn_MorePOGID.Size = new System.Drawing.Size(41, 26);
            this.btn_MorePOGID.TabIndex = 68;
            this.btn_MorePOGID.Text = "...";
            this.btn_MorePOGID.UseVisualStyleBackColor = true;
            this.btn_MorePOGID.Click += new System.EventHandler(this.btn_MorePOGID_Click);
            // 
            // btn_MorePOGSupplier
            // 
            this.btn_MorePOGSupplier.Location = new System.Drawing.Point(300, 51);
            this.btn_MorePOGSupplier.Margin = new System.Windows.Forms.Padding(4);
            this.btn_MorePOGSupplier.Name = "btn_MorePOGSupplier";
            this.btn_MorePOGSupplier.Size = new System.Drawing.Size(41, 26);
            this.btn_MorePOGSupplier.TabIndex = 67;
            this.btn_MorePOGSupplier.Text = "...";
            this.btn_MorePOGSupplier.UseVisualStyleBackColor = true;
            this.btn_MorePOGSupplier.Click += new System.EventHandler(this.btn_MorePOGSupplier_Click);
            // 
            // lab_POGNotes
            // 
            this.lab_POGNotes.AutoSize = true;
            this.lab_POGNotes.Location = new System.Drawing.Point(24, 360);
            this.lab_POGNotes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_POGNotes.Name = "lab_POGNotes";
            this.lab_POGNotes.Size = new System.Drawing.Size(84, 15);
            this.lab_POGNotes.TabIndex = 66;
            this.lab_POGNotes.Text = "备    注：";
            // 
            // lab_POGProductionDate
            // 
            this.lab_POGProductionDate.AutoSize = true;
            this.lab_POGProductionDate.Location = new System.Drawing.Point(25, 333);
            this.lab_POGProductionDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_POGProductionDate.Name = "lab_POGProductionDate";
            this.lab_POGProductionDate.Size = new System.Drawing.Size(82, 15);
            this.lab_POGProductionDate.TabIndex = 65;
            this.lab_POGProductionDate.Text = "生产日期：";
            // 
            // lab_POGShelfLife
            // 
            this.lab_POGShelfLife.AutoSize = true;
            this.lab_POGShelfLife.Location = new System.Drawing.Point(25, 296);
            this.lab_POGShelfLife.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_POGShelfLife.Name = "lab_POGShelfLife";
            this.lab_POGShelfLife.Size = new System.Drawing.Size(83, 15);
            this.lab_POGShelfLife.TabIndex = 64;
            this.lab_POGShelfLife.Text = "保 质 期：";
            // 
            // lab_POGMinimumInventory
            // 
            this.lab_POGMinimumInventory.AutoSize = true;
            this.lab_POGMinimumInventory.Location = new System.Drawing.Point(301, 262);
            this.lab_POGMinimumInventory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_POGMinimumInventory.Name = "lab_POGMinimumInventory";
            this.lab_POGMinimumInventory.Size = new System.Drawing.Size(82, 15);
            this.lab_POGMinimumInventory.TabIndex = 63;
            this.lab_POGMinimumInventory.Text = "最小库存：";
            // 
            // lab_POAmount
            // 
            this.lab_POAmount.AutoSize = true;
            this.lab_POAmount.Location = new System.Drawing.Point(24, 262);
            this.lab_POAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_POAmount.Name = "lab_POAmount";
            this.lab_POAmount.Size = new System.Drawing.Size(82, 15);
            this.lab_POAmount.TabIndex = 62;
            this.lab_POAmount.Text = "进货数量：";
            // 
            // lab_POGPrice
            // 
            this.lab_POGPrice.AutoSize = true;
            this.lab_POGPrice.Location = new System.Drawing.Point(301, 227);
            this.lab_POGPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_POGPrice.Name = "lab_POGPrice";
            this.lab_POGPrice.Size = new System.Drawing.Size(84, 15);
            this.lab_POGPrice.TabIndex = 61;
            this.lab_POGPrice.Text = "售    价：";
            // 
            // lab_POGBid
            // 
            this.lab_POGBid.AutoSize = true;
            this.lab_POGBid.Location = new System.Drawing.Point(24, 227);
            this.lab_POGBid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_POGBid.Name = "lab_POGBid";
            this.lab_POGBid.Size = new System.Drawing.Size(84, 15);
            this.lab_POGBid.TabIndex = 60;
            this.lab_POGBid.Text = "进    价：";
            // 
            // lab_POGUnit
            // 
            this.lab_POGUnit.AutoSize = true;
            this.lab_POGUnit.Location = new System.Drawing.Point(301, 194);
            this.lab_POGUnit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_POGUnit.Name = "lab_POGUnit";
            this.lab_POGUnit.Size = new System.Drawing.Size(84, 15);
            this.lab_POGUnit.TabIndex = 59;
            this.lab_POGUnit.Text = "单    位：";
            // 
            // lab_POGCID
            // 
            this.lab_POGCID.AutoSize = true;
            this.lab_POGCID.Location = new System.Drawing.Point(24, 194);
            this.lab_POGCID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_POGCID.Name = "lab_POGCID";
            this.lab_POGCID.Size = new System.Drawing.Size(84, 15);
            this.lab_POGCID.TabIndex = 58;
            this.lab_POGCID.Text = "类    别：";
            // 
            // lab_POGName
            // 
            this.lab_POGName.AutoSize = true;
            this.lab_POGName.Location = new System.Drawing.Point(24, 158);
            this.lab_POGName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_POGName.Name = "lab_POGName";
            this.lab_POGName.Size = new System.Drawing.Size(82, 15);
            this.lab_POGName.TabIndex = 57;
            this.lab_POGName.Text = "商品名称：";
            // 
            // lab_POGID
            // 
            this.lab_POGID.AutoSize = true;
            this.lab_POGID.Location = new System.Drawing.Point(24, 124);
            this.lab_POGID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_POGID.Name = "lab_POGID";
            this.lab_POGID.Size = new System.Drawing.Size(82, 15);
            this.lab_POGID.TabIndex = 56;
            this.lab_POGID.Text = "商品编号：";
            // 
            // lab_PODate
            // 
            this.lab_PODate.AutoSize = true;
            this.lab_PODate.Location = new System.Drawing.Point(24, 92);
            this.lab_PODate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_PODate.Name = "lab_PODate";
            this.lab_PODate.Size = new System.Drawing.Size(82, 15);
            this.lab_PODate.TabIndex = 55;
            this.lab_PODate.Text = "进货日期：";
            // 
            // lab_POGSupplier
            // 
            this.lab_POGSupplier.AutoSize = true;
            this.lab_POGSupplier.Location = new System.Drawing.Point(24, 56);
            this.lab_POGSupplier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_POGSupplier.Name = "lab_POGSupplier";
            this.lab_POGSupplier.Size = new System.Drawing.Size(83, 15);
            this.lab_POGSupplier.TabIndex = 54;
            this.lab_POGSupplier.Text = "供 应 商：";
            // 
            // lab_POID
            // 
            this.lab_POID.AutoSize = true;
            this.lab_POID.Location = new System.Drawing.Point(24, 21);
            this.lab_POID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_POID.Name = "lab_POID";
            this.lab_POID.Size = new System.Drawing.Size(82, 15);
            this.lab_POID.TabIndex = 53;
            this.lab_POID.Text = "进货编号：";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(429, 442);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(100, 29);
            this.btn_Cancel.TabIndex = 52;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(321, 442);
            this.btn_Submit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(100, 29);
            this.btn_Submit.TabIndex = 51;
            this.btn_Submit.Text = "确定";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // richtxtbox_POGNotes
            // 
            this.richtxtbox_POGNotes.Location = new System.Drawing.Point(118, 356);
            this.richtxtbox_POGNotes.Margin = new System.Windows.Forms.Padding(4);
            this.richtxtbox_POGNotes.Name = "richtxtbox_POGNotes";
            this.richtxtbox_POGNotes.Size = new System.Drawing.Size(409, 78);
            this.richtxtbox_POGNotes.TabIndex = 50;
            this.richtxtbox_POGNotes.Text = "";
            // 
            // dtp_POGProductionDate
            // 
            this.dtp_POGProductionDate.Location = new System.Drawing.Point(120, 326);
            this.dtp_POGProductionDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_POGProductionDate.Name = "dtp_POGProductionDate";
            this.dtp_POGProductionDate.Size = new System.Drawing.Size(172, 25);
            this.dtp_POGProductionDate.TabIndex = 49;
            // 
            // txtbox_POGShelfLife_MonthDay
            // 
            this.txtbox_POGShelfLife_MonthDay.Location = new System.Drawing.Point(120, 292);
            this.txtbox_POGShelfLife_MonthDay.Margin = new System.Windows.Forms.Padding(4);
            this.txtbox_POGShelfLife_MonthDay.Name = "txtbox_POGShelfLife_MonthDay";
            this.txtbox_POGShelfLife_MonthDay.Size = new System.Drawing.Size(45, 25);
            this.txtbox_POGShelfLife_MonthDay.TabIndex = 48;
            // 
            // txtbox_POGMinimumInventory
            // 
            this.txtbox_POGMinimumInventory.Location = new System.Drawing.Point(396, 257);
            this.txtbox_POGMinimumInventory.Margin = new System.Windows.Forms.Padding(4);
            this.txtbox_POGMinimumInventory.Name = "txtbox_POGMinimumInventory";
            this.txtbox_POGMinimumInventory.Size = new System.Drawing.Size(132, 25);
            this.txtbox_POGMinimumInventory.TabIndex = 47;
            // 
            // txtbox_POAmount
            // 
            this.txtbox_POAmount.Location = new System.Drawing.Point(118, 258);
            this.txtbox_POAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtbox_POAmount.Name = "txtbox_POAmount";
            this.txtbox_POAmount.Size = new System.Drawing.Size(132, 25);
            this.txtbox_POAmount.TabIndex = 46;
            // 
            // txtbox_POGPrice
            // 
            this.txtbox_POGPrice.Location = new System.Drawing.Point(396, 223);
            this.txtbox_POGPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtbox_POGPrice.Name = "txtbox_POGPrice";
            this.txtbox_POGPrice.Size = new System.Drawing.Size(132, 25);
            this.txtbox_POGPrice.TabIndex = 45;
            // 
            // txtbox_POGBid
            // 
            this.txtbox_POGBid.Location = new System.Drawing.Point(118, 223);
            this.txtbox_POGBid.Margin = new System.Windows.Forms.Padding(4);
            this.txtbox_POGBid.Name = "txtbox_POGBid";
            this.txtbox_POGBid.Size = new System.Drawing.Size(132, 25);
            this.txtbox_POGBid.TabIndex = 44;
            // 
            // cmbox_POGUnit
            // 
            this.cmbox_POGUnit.FormattingEnabled = true;
            this.cmbox_POGUnit.Location = new System.Drawing.Point(396, 191);
            this.cmbox_POGUnit.Margin = new System.Windows.Forms.Padding(4);
            this.cmbox_POGUnit.Name = "cmbox_POGUnit";
            this.cmbox_POGUnit.Size = new System.Drawing.Size(132, 23);
            this.cmbox_POGUnit.TabIndex = 43;
            // 
            // cmbox_POGCID
            // 
            this.cmbox_POGCID.FormattingEnabled = true;
            this.cmbox_POGCID.Items.AddRange(new object[] {
            "水果",
            "qwe"});
            this.cmbox_POGCID.Location = new System.Drawing.Point(118, 190);
            this.cmbox_POGCID.Margin = new System.Windows.Forms.Padding(4);
            this.cmbox_POGCID.Name = "cmbox_POGCID";
            this.cmbox_POGCID.Size = new System.Drawing.Size(132, 23);
            this.cmbox_POGCID.TabIndex = 42;
            // 
            // txtbox_POGName
            // 
            this.txtbox_POGName.Location = new System.Drawing.Point(118, 154);
            this.txtbox_POGName.Margin = new System.Windows.Forms.Padding(4);
            this.txtbox_POGName.Name = "txtbox_POGName";
            this.txtbox_POGName.Size = new System.Drawing.Size(172, 25);
            this.txtbox_POGName.TabIndex = 41;
            // 
            // txtbox_POGID
            // 
            this.txtbox_POGID.Location = new System.Drawing.Point(118, 120);
            this.txtbox_POGID.Margin = new System.Windows.Forms.Padding(4);
            this.txtbox_POGID.Name = "txtbox_POGID";
            this.txtbox_POGID.Size = new System.Drawing.Size(172, 25);
            this.txtbox_POGID.TabIndex = 40;
            // 
            // dtp_PODate
            // 
            this.dtp_PODate.Location = new System.Drawing.Point(118, 84);
            this.dtp_PODate.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_PODate.Name = "dtp_PODate";
            this.dtp_PODate.Size = new System.Drawing.Size(172, 25);
            this.dtp_PODate.TabIndex = 39;
            // 
            // txtbox_POGSupplier
            // 
            this.txtbox_POGSupplier.Location = new System.Drawing.Point(118, 51);
            this.txtbox_POGSupplier.Margin = new System.Windows.Forms.Padding(4);
            this.txtbox_POGSupplier.Name = "txtbox_POGSupplier";
            this.txtbox_POGSupplier.Size = new System.Drawing.Size(172, 25);
            this.txtbox_POGSupplier.TabIndex = 38;
            // 
            // txtbox_POID
            // 
            this.txtbox_POID.Location = new System.Drawing.Point(118, 17);
            this.txtbox_POID.Margin = new System.Windows.Forms.Padding(4);
            this.txtbox_POID.Name = "txtbox_POID";
            this.txtbox_POID.ReadOnly = true;
            this.txtbox_POID.Size = new System.Drawing.Size(172, 25);
            this.txtbox_POID.TabIndex = 37;
            // 
            // FrmNEPurchaseOrder
            // 
            this.AcceptButton = this.btn_Submit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 488);
            this.Controls.Add(this.cmbox_POGShelfLife_MonthDay);
            this.Controls.Add(this.btn_AddPOGCID);
            this.Controls.Add(this.btn_MorePOGID);
            this.Controls.Add(this.btn_MorePOGSupplier);
            this.Controls.Add(this.lab_POGNotes);
            this.Controls.Add(this.lab_POGProductionDate);
            this.Controls.Add(this.lab_POGShelfLife);
            this.Controls.Add(this.lab_POGMinimumInventory);
            this.Controls.Add(this.lab_POAmount);
            this.Controls.Add(this.lab_POGPrice);
            this.Controls.Add(this.lab_POGBid);
            this.Controls.Add(this.lab_POGUnit);
            this.Controls.Add(this.lab_POGCID);
            this.Controls.Add(this.lab_POGName);
            this.Controls.Add(this.lab_POGID);
            this.Controls.Add(this.lab_PODate);
            this.Controls.Add(this.lab_POGSupplier);
            this.Controls.Add(this.lab_POID);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.richtxtbox_POGNotes);
            this.Controls.Add(this.dtp_POGProductionDate);
            this.Controls.Add(this.txtbox_POGShelfLife_MonthDay);
            this.Controls.Add(this.txtbox_POGMinimumInventory);
            this.Controls.Add(this.txtbox_POAmount);
            this.Controls.Add(this.txtbox_POGPrice);
            this.Controls.Add(this.txtbox_POGBid);
            this.Controls.Add(this.cmbox_POGUnit);
            this.Controls.Add(this.cmbox_POGCID);
            this.Controls.Add(this.txtbox_POGName);
            this.Controls.Add(this.txtbox_POGID);
            this.Controls.Add(this.dtp_PODate);
            this.Controls.Add(this.txtbox_POGSupplier);
            this.Controls.Add(this.txtbox_POID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmNEPurchaseOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmNEPurchaseOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbox_POGShelfLife_MonthDay;
        private System.Windows.Forms.Button btn_AddPOGCID;
        private System.Windows.Forms.Button btn_MorePOGID;
        private System.Windows.Forms.Button btn_MorePOGSupplier;
        private System.Windows.Forms.Label lab_POGNotes;
        private System.Windows.Forms.Label lab_POGProductionDate;
        private System.Windows.Forms.Label lab_POGShelfLife;
        private System.Windows.Forms.Label lab_POGMinimumInventory;
        private System.Windows.Forms.Label lab_POAmount;
        private System.Windows.Forms.Label lab_POGPrice;
        private System.Windows.Forms.Label lab_POGBid;
        private System.Windows.Forms.Label lab_POGUnit;
        private System.Windows.Forms.Label lab_POGCID;
        private System.Windows.Forms.Label lab_POGName;
        private System.Windows.Forms.Label lab_POGID;
        private System.Windows.Forms.Label lab_PODate;
        private System.Windows.Forms.Label lab_POGSupplier;
        private System.Windows.Forms.Label lab_POID;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.RichTextBox richtxtbox_POGNotes;
        private System.Windows.Forms.DateTimePicker dtp_POGProductionDate;
        private System.Windows.Forms.TextBox txtbox_POGShelfLife_MonthDay;
        private System.Windows.Forms.TextBox txtbox_POGMinimumInventory;
        private System.Windows.Forms.TextBox txtbox_POAmount;
        private System.Windows.Forms.TextBox txtbox_POGPrice;
        private System.Windows.Forms.TextBox txtbox_POGBid;
        private System.Windows.Forms.ComboBox cmbox_POGUnit;
        private System.Windows.Forms.ComboBox cmbox_POGCID;
        private System.Windows.Forms.TextBox txtbox_POGName;
        private System.Windows.Forms.TextBox txtbox_POGID;
        private System.Windows.Forms.DateTimePicker dtp_PODate;
        private System.Windows.Forms.TextBox txtbox_POGSupplier;
        private System.Windows.Forms.TextBox txtbox_POID;
    }
}