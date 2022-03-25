namespace SuperMarket.UI
{
    partial class FrmForget
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmForget));
            this.tabControl1 = new CCWin.SkinControl.SkinTabControl();
            this.tabPage1 = new CCWin.SkinControl.SkinTabPage();
            this.btn_WBack = new CCWin.SkinControl.SkinButton();
            this.btn_WSubmit = new CCWin.SkinControl.SkinButton();
            this.radbtn_Tel = new CCWin.SkinControl.SkinRadioButton();
            this.lab_Find = new CCWin.SkinControl.SkinLabel();
            this.tabPage2 = new CCWin.SkinControl.SkinTabPage();
            this.txtbox_CheckNewPasswd = new CCWin.SkinControl.SkinTextBox();
            this.txtbox_NewPasswd = new CCWin.SkinControl.SkinTextBox();
            this.txtbox_Tel = new CCWin.SkinControl.SkinTextBox();
            this.txtbox_UserName = new CCWin.SkinControl.SkinTextBox();
            this.btn_CBack = new CCWin.SkinControl.SkinButton();
            this.btn_CSubmit = new CCWin.SkinControl.SkinButton();
            this.lab_CheckNewPasswd = new CCWin.SkinControl.SkinLabel();
            this.lab_NewPasswd = new CCWin.SkinControl.SkinLabel();
            this.lab_Tel = new CCWin.SkinControl.SkinLabel();
            this.lab_UserName = new CCWin.SkinControl.SkinLabel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.AnimatorType = CCWin.SkinControl.AnimationType.HorizSlide;
            this.tabControl1.CloseRect = new System.Drawing.Rectangle(2, 2, 12, 12);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.HeadBack = null;
            this.tabControl1.ImgTxtOffset = new System.Drawing.Point(0, 0);
            this.tabControl1.ItemSize = new System.Drawing.Size(90, 36);
            this.tabControl1.Location = new System.Drawing.Point(61, 55);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.PageArrowDown = ((System.Drawing.Image)(resources.GetObject("tabControl1.PageArrowDown")));
            this.tabControl1.PageArrowHover = ((System.Drawing.Image)(resources.GetObject("tabControl1.PageArrowHover")));
            this.tabControl1.PageCloseHover = ((System.Drawing.Image)(resources.GetObject("tabControl1.PageCloseHover")));
            this.tabControl1.PageCloseNormal = ((System.Drawing.Image)(resources.GetObject("tabControl1.PageCloseNormal")));
            this.tabControl1.PageDown = ((System.Drawing.Image)(resources.GetObject("tabControl1.PageDown")));
            this.tabControl1.PageHover = ((System.Drawing.Image)(resources.GetObject("tabControl1.PageHover")));
            this.tabControl1.PageImagePosition = CCWin.SkinControl.SkinTabControl.ePageImagePosition.Left;
            this.tabControl1.PageNorml = null;
            this.tabControl1.SelectedIndex = 1;
            this.tabControl1.Size = new System.Drawing.Size(461, 337);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.btn_WBack);
            this.tabPage1.Controls.Add(this.btn_WSubmit);
            this.tabPage1.Controls.Add(this.radbtn_Tel);
            this.tabPage1.Controls.Add(this.lab_Find);
            this.tabPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPage1.Location = new System.Drawing.Point(0, 36);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(461, 301);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.TabItemImage = null;
            this.tabPage1.Text = "tabPage1";
            // 
            // btn_WBack
            // 
            this.btn_WBack.BackColor = System.Drawing.Color.Transparent;
            this.btn_WBack.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_WBack.DownBack = null;
            this.btn_WBack.Location = new System.Drawing.Point(243, 202);
            this.btn_WBack.MouseBack = null;
            this.btn_WBack.Name = "btn_WBack";
            this.btn_WBack.NormlBack = null;
            this.btn_WBack.Size = new System.Drawing.Size(93, 35);
            this.btn_WBack.TabIndex = 3;
            this.btn_WBack.Text = "返回";
            this.btn_WBack.UseVisualStyleBackColor = false;
            this.btn_WBack.Click += new System.EventHandler(this.btn_WBack_Click);
            // 
            // btn_WSubmit
            // 
            this.btn_WSubmit.BackColor = System.Drawing.Color.Transparent;
            this.btn_WSubmit.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_WSubmit.DownBack = null;
            this.btn_WSubmit.Location = new System.Drawing.Point(71, 202);
            this.btn_WSubmit.MouseBack = null;
            this.btn_WSubmit.Name = "btn_WSubmit";
            this.btn_WSubmit.NormlBack = null;
            this.btn_WSubmit.Size = new System.Drawing.Size(87, 35);
            this.btn_WSubmit.TabIndex = 2;
            this.btn_WSubmit.Text = "确定";
            this.btn_WSubmit.UseVisualStyleBackColor = false;
            this.btn_WSubmit.Click += new System.EventHandler(this.btn_WSubmit_Click);
            // 
            // radbtn_Tel
            // 
            this.radbtn_Tel.AutoSize = true;
            this.radbtn_Tel.BackColor = System.Drawing.Color.Transparent;
            this.radbtn_Tel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.radbtn_Tel.DownBack = null;
            this.radbtn_Tel.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radbtn_Tel.Location = new System.Drawing.Point(122, 116);
            this.radbtn_Tel.MouseBack = null;
            this.radbtn_Tel.Name = "radbtn_Tel";
            this.radbtn_Tel.NormlBack = null;
            this.radbtn_Tel.SelectedDownBack = null;
            this.radbtn_Tel.SelectedMouseBack = null;
            this.radbtn_Tel.SelectedNormlBack = null;
            this.radbtn_Tel.Size = new System.Drawing.Size(185, 29);
            this.radbtn_Tel.TabIndex = 1;
            this.radbtn_Tel.TabStop = true;
            this.radbtn_Tel.Text = "通过手机号码找回";
            this.radbtn_Tel.UseVisualStyleBackColor = false;
            // 
            // lab_Find
            // 
            this.lab_Find.AutoSize = true;
            this.lab_Find.BackColor = System.Drawing.Color.Transparent;
            this.lab_Find.BorderColor = System.Drawing.Color.White;
            this.lab_Find.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_Find.Location = new System.Drawing.Point(33, 48);
            this.lab_Find.Name = "lab_Find";
            this.lab_Find.Size = new System.Drawing.Size(112, 27);
            this.lab_Find.TabIndex = 0;
            this.lab_Find.Text = "找回方式：";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.txtbox_CheckNewPasswd);
            this.tabPage2.Controls.Add(this.txtbox_NewPasswd);
            this.tabPage2.Controls.Add(this.txtbox_Tel);
            this.tabPage2.Controls.Add(this.txtbox_UserName);
            this.tabPage2.Controls.Add(this.btn_CBack);
            this.tabPage2.Controls.Add(this.btn_CSubmit);
            this.tabPage2.Controls.Add(this.lab_CheckNewPasswd);
            this.tabPage2.Controls.Add(this.lab_NewPasswd);
            this.tabPage2.Controls.Add(this.lab_Tel);
            this.tabPage2.Controls.Add(this.lab_UserName);
            this.tabPage2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPage2.Location = new System.Drawing.Point(0, 36);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(461, 301);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.TabItemImage = null;
            this.tabPage2.Text = "tabPage2";
            // 
            // txtbox_CheckNewPasswd
            // 
            this.txtbox_CheckNewPasswd.BackColor = System.Drawing.Color.Transparent;
            this.txtbox_CheckNewPasswd.DownBack = null;
            this.txtbox_CheckNewPasswd.Icon = null;
            this.txtbox_CheckNewPasswd.IconIsButton = false;
            this.txtbox_CheckNewPasswd.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtbox_CheckNewPasswd.IsPasswordChat = '\0';
            this.txtbox_CheckNewPasswd.IsSystemPasswordChar = false;
            this.txtbox_CheckNewPasswd.Lines = new string[0];
            this.txtbox_CheckNewPasswd.Location = new System.Drawing.Point(156, 155);
            this.txtbox_CheckNewPasswd.Margin = new System.Windows.Forms.Padding(0);
            this.txtbox_CheckNewPasswd.MaxLength = 32767;
            this.txtbox_CheckNewPasswd.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtbox_CheckNewPasswd.MouseBack = null;
            this.txtbox_CheckNewPasswd.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtbox_CheckNewPasswd.Multiline = false;
            this.txtbox_CheckNewPasswd.Name = "txtbox_CheckNewPasswd";
            this.txtbox_CheckNewPasswd.NormlBack = null;
            this.txtbox_CheckNewPasswd.Padding = new System.Windows.Forms.Padding(5);
            this.txtbox_CheckNewPasswd.ReadOnly = false;
            this.txtbox_CheckNewPasswd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtbox_CheckNewPasswd.Size = new System.Drawing.Size(185, 28);
            // 
            // 
            // 
            this.txtbox_CheckNewPasswd.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_CheckNewPasswd.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbox_CheckNewPasswd.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtbox_CheckNewPasswd.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtbox_CheckNewPasswd.SkinTxt.Name = "BaseText";
            this.txtbox_CheckNewPasswd.SkinTxt.Size = new System.Drawing.Size(175, 22);
            this.txtbox_CheckNewPasswd.SkinTxt.TabIndex = 0;
            this.txtbox_CheckNewPasswd.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtbox_CheckNewPasswd.SkinTxt.WaterText = "";
            this.txtbox_CheckNewPasswd.TabIndex = 9;
            this.txtbox_CheckNewPasswd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtbox_CheckNewPasswd.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtbox_CheckNewPasswd.WaterText = "";
            this.txtbox_CheckNewPasswd.WordWrap = true;
            // 
            // txtbox_NewPasswd
            // 
            this.txtbox_NewPasswd.BackColor = System.Drawing.Color.Transparent;
            this.txtbox_NewPasswd.DownBack = null;
            this.txtbox_NewPasswd.Icon = null;
            this.txtbox_NewPasswd.IconIsButton = false;
            this.txtbox_NewPasswd.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtbox_NewPasswd.IsPasswordChat = '\0';
            this.txtbox_NewPasswd.IsSystemPasswordChar = false;
            this.txtbox_NewPasswd.Lines = new string[0];
            this.txtbox_NewPasswd.Location = new System.Drawing.Point(156, 109);
            this.txtbox_NewPasswd.Margin = new System.Windows.Forms.Padding(0);
            this.txtbox_NewPasswd.MaxLength = 32767;
            this.txtbox_NewPasswd.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtbox_NewPasswd.MouseBack = null;
            this.txtbox_NewPasswd.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtbox_NewPasswd.Multiline = false;
            this.txtbox_NewPasswd.Name = "txtbox_NewPasswd";
            this.txtbox_NewPasswd.NormlBack = null;
            this.txtbox_NewPasswd.Padding = new System.Windows.Forms.Padding(5);
            this.txtbox_NewPasswd.ReadOnly = false;
            this.txtbox_NewPasswd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtbox_NewPasswd.Size = new System.Drawing.Size(185, 28);
            // 
            // 
            // 
            this.txtbox_NewPasswd.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_NewPasswd.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbox_NewPasswd.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtbox_NewPasswd.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtbox_NewPasswd.SkinTxt.Name = "BaseText";
            this.txtbox_NewPasswd.SkinTxt.Size = new System.Drawing.Size(175, 22);
            this.txtbox_NewPasswd.SkinTxt.TabIndex = 0;
            this.txtbox_NewPasswd.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtbox_NewPasswd.SkinTxt.WaterText = "";
            this.txtbox_NewPasswd.TabIndex = 8;
            this.txtbox_NewPasswd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtbox_NewPasswd.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtbox_NewPasswd.WaterText = "";
            this.txtbox_NewPasswd.WordWrap = true;
            // 
            // txtbox_Tel
            // 
            this.txtbox_Tel.BackColor = System.Drawing.Color.Transparent;
            this.txtbox_Tel.DownBack = null;
            this.txtbox_Tel.Icon = null;
            this.txtbox_Tel.IconIsButton = false;
            this.txtbox_Tel.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtbox_Tel.IsPasswordChat = '\0';
            this.txtbox_Tel.IsSystemPasswordChar = false;
            this.txtbox_Tel.Lines = new string[0];
            this.txtbox_Tel.Location = new System.Drawing.Point(156, 63);
            this.txtbox_Tel.Margin = new System.Windows.Forms.Padding(0);
            this.txtbox_Tel.MaxLength = 32767;
            this.txtbox_Tel.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtbox_Tel.MouseBack = null;
            this.txtbox_Tel.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtbox_Tel.Multiline = false;
            this.txtbox_Tel.Name = "txtbox_Tel";
            this.txtbox_Tel.NormlBack = null;
            this.txtbox_Tel.Padding = new System.Windows.Forms.Padding(5);
            this.txtbox_Tel.ReadOnly = false;
            this.txtbox_Tel.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtbox_Tel.Size = new System.Drawing.Size(185, 28);
            // 
            // 
            // 
            this.txtbox_Tel.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_Tel.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbox_Tel.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtbox_Tel.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtbox_Tel.SkinTxt.Name = "BaseText";
            this.txtbox_Tel.SkinTxt.Size = new System.Drawing.Size(175, 22);
            this.txtbox_Tel.SkinTxt.TabIndex = 0;
            this.txtbox_Tel.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtbox_Tel.SkinTxt.WaterText = "";
            this.txtbox_Tel.TabIndex = 7;
            this.txtbox_Tel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtbox_Tel.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtbox_Tel.WaterText = "";
            this.txtbox_Tel.WordWrap = true;
            // 
            // txtbox_UserName
            // 
            this.txtbox_UserName.BackColor = System.Drawing.Color.Transparent;
            this.txtbox_UserName.DownBack = null;
            this.txtbox_UserName.Icon = null;
            this.txtbox_UserName.IconIsButton = false;
            this.txtbox_UserName.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtbox_UserName.IsPasswordChat = '\0';
            this.txtbox_UserName.IsSystemPasswordChar = false;
            this.txtbox_UserName.Lines = new string[0];
            this.txtbox_UserName.Location = new System.Drawing.Point(156, 17);
            this.txtbox_UserName.Margin = new System.Windows.Forms.Padding(0);
            this.txtbox_UserName.MaxLength = 32767;
            this.txtbox_UserName.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtbox_UserName.MouseBack = null;
            this.txtbox_UserName.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtbox_UserName.Multiline = false;
            this.txtbox_UserName.Name = "txtbox_UserName";
            this.txtbox_UserName.NormlBack = null;
            this.txtbox_UserName.Padding = new System.Windows.Forms.Padding(5);
            this.txtbox_UserName.ReadOnly = false;
            this.txtbox_UserName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtbox_UserName.Size = new System.Drawing.Size(185, 28);
            // 
            // 
            // 
            this.txtbox_UserName.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_UserName.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbox_UserName.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtbox_UserName.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtbox_UserName.SkinTxt.Name = "BaseText";
            this.txtbox_UserName.SkinTxt.Size = new System.Drawing.Size(175, 22);
            this.txtbox_UserName.SkinTxt.TabIndex = 0;
            this.txtbox_UserName.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtbox_UserName.SkinTxt.WaterText = "";
            this.txtbox_UserName.TabIndex = 6;
            this.txtbox_UserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtbox_UserName.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtbox_UserName.WaterText = "";
            this.txtbox_UserName.WordWrap = true;
            // 
            // btn_CBack
            // 
            this.btn_CBack.BackColor = System.Drawing.Color.Transparent;
            this.btn_CBack.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_CBack.DownBack = null;
            this.btn_CBack.Location = new System.Drawing.Point(260, 230);
            this.btn_CBack.MouseBack = null;
            this.btn_CBack.Name = "btn_CBack";
            this.btn_CBack.NormlBack = null;
            this.btn_CBack.Size = new System.Drawing.Size(84, 29);
            this.btn_CBack.TabIndex = 5;
            this.btn_CBack.Text = "返回";
            this.btn_CBack.UseVisualStyleBackColor = false;
            this.btn_CBack.Click += new System.EventHandler(this.btn_CBack_Click);
            // 
            // btn_CSubmit
            // 
            this.btn_CSubmit.BackColor = System.Drawing.Color.Transparent;
            this.btn_CSubmit.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_CSubmit.DownBack = null;
            this.btn_CSubmit.Location = new System.Drawing.Point(60, 230);
            this.btn_CSubmit.MouseBack = null;
            this.btn_CSubmit.Name = "btn_CSubmit";
            this.btn_CSubmit.NormlBack = null;
            this.btn_CSubmit.Size = new System.Drawing.Size(84, 29);
            this.btn_CSubmit.TabIndex = 4;
            this.btn_CSubmit.Text = "确定";
            this.btn_CSubmit.UseVisualStyleBackColor = false;
            this.btn_CSubmit.Click += new System.EventHandler(this.btn_CSubmit_Click);
            // 
            // lab_CheckNewPasswd
            // 
            this.lab_CheckNewPasswd.AutoSize = true;
            this.lab_CheckNewPasswd.BackColor = System.Drawing.Color.Transparent;
            this.lab_CheckNewPasswd.BorderColor = System.Drawing.Color.White;
            this.lab_CheckNewPasswd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_CheckNewPasswd.Location = new System.Drawing.Point(37, 163);
            this.lab_CheckNewPasswd.Name = "lab_CheckNewPasswd";
            this.lab_CheckNewPasswd.Size = new System.Drawing.Size(99, 20);
            this.lab_CheckNewPasswd.TabIndex = 3;
            this.lab_CheckNewPasswd.Text = "确认新密码：";
            // 
            // lab_NewPasswd
            // 
            this.lab_NewPasswd.AutoSize = true;
            this.lab_NewPasswd.BackColor = System.Drawing.Color.Transparent;
            this.lab_NewPasswd.BorderColor = System.Drawing.Color.White;
            this.lab_NewPasswd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_NewPasswd.Location = new System.Drawing.Point(37, 117);
            this.lab_NewPasswd.Name = "lab_NewPasswd";
            this.lab_NewPasswd.Size = new System.Drawing.Size(85, 20);
            this.lab_NewPasswd.TabIndex = 2;
            this.lab_NewPasswd.Text = "新  密  码：";
            // 
            // lab_Tel
            // 
            this.lab_Tel.AutoSize = true;
            this.lab_Tel.BackColor = System.Drawing.Color.Transparent;
            this.lab_Tel.BorderColor = System.Drawing.Color.White;
            this.lab_Tel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_Tel.Location = new System.Drawing.Point(37, 71);
            this.lab_Tel.Name = "lab_Tel";
            this.lab_Tel.Size = new System.Drawing.Size(99, 20);
            this.lab_Tel.TabIndex = 1;
            this.lab_Tel.Text = "绑定手机号：";
            // 
            // lab_UserName
            // 
            this.lab_UserName.AutoSize = true;
            this.lab_UserName.BackColor = System.Drawing.Color.Transparent;
            this.lab_UserName.BorderColor = System.Drawing.Color.White;
            this.lab_UserName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_UserName.Location = new System.Drawing.Point(37, 25);
            this.lab_UserName.Name = "lab_UserName";
            this.lab_UserName.Size = new System.Drawing.Size(85, 20);
            this.lab_UserName.TabIndex = 0;
            this.lab_UserName.Text = "用  户  名：";
            // 
            // FrmForget
            // 
            this.AcceptButton = this.btn_CSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 448);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmForget";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "忘记密码";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormForget_FormClosing);
            this.Load += new System.EventHandler(this.FrmForget_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinTabControl tabControl1;
        private CCWin.SkinControl.SkinTabPage tabPage1;
        private CCWin.SkinControl.SkinButton btn_WBack;
        private CCWin.SkinControl.SkinButton btn_WSubmit;
        private CCWin.SkinControl.SkinRadioButton radbtn_Tel;
        private CCWin.SkinControl.SkinLabel lab_Find;
        private CCWin.SkinControl.SkinTabPage tabPage2;
        private CCWin.SkinControl.SkinLabel lab_CheckNewPasswd;
        private CCWin.SkinControl.SkinLabel lab_NewPasswd;
        private CCWin.SkinControl.SkinLabel lab_Tel;
        private CCWin.SkinControl.SkinLabel lab_UserName;
        private CCWin.SkinControl.SkinTextBox txtbox_CheckNewPasswd;
        private CCWin.SkinControl.SkinTextBox txtbox_NewPasswd;
        private CCWin.SkinControl.SkinTextBox txtbox_Tel;
        private CCWin.SkinControl.SkinTextBox txtbox_UserName;
        private CCWin.SkinControl.SkinButton btn_CBack;
        private CCWin.SkinControl.SkinButton btn_CSubmit;
    }
}