namespace SuperMarket
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.skinPictureBox1 = new CCWin.SkinControl.SkinPictureBox();
            this.skinPanel1 = new CCWin.SkinControl.SkinPanel();
            this.picbox_Captcha = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbox_Captcha = new CCWin.SkinControl.SkinTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.skinButton1 = new CCWin.SkinControl.SkinButton();
            this.skinButton3 = new CCWin.SkinControl.SkinButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbox_Passwd = new CCWin.SkinControl.SkinTextBox();
            this.txtbox_UserName = new CCWin.SkinControl.SkinTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox1)).BeginInit();
            this.skinPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_Captcha)).BeginInit();
            this.SuspendLayout();
            // 
            // skinPictureBox1
            // 
            this.skinPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.skinPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("skinPictureBox1.Image")));
            this.skinPictureBox1.Location = new System.Drawing.Point(241, 87);
            this.skinPictureBox1.Name = "skinPictureBox1";
            this.skinPictureBox1.Size = new System.Drawing.Size(117, 104);
            this.skinPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.skinPictureBox1.TabIndex = 0;
            this.skinPictureBox1.TabStop = false;
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.White;
            this.skinPanel1.Controls.Add(this.picbox_Captcha);
            this.skinPanel1.Controls.Add(this.label4);
            this.skinPanel1.Controls.Add(this.txtbox_Captcha);
            this.skinPanel1.Controls.Add(this.label3);
            this.skinPanel1.Controls.Add(this.skinButton1);
            this.skinPanel1.Controls.Add(this.skinButton3);
            this.skinPanel1.Controls.Add(this.label2);
            this.skinPanel1.Controls.Add(this.label1);
            this.skinPanel1.Controls.Add(this.txtbox_Passwd);
            this.skinPanel1.Controls.Add(this.txtbox_UserName);
            this.skinPanel1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel1.DownBack = null;
            this.skinPanel1.Location = new System.Drawing.Point(-1, 126);
            this.skinPanel1.MouseBack = null;
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.NormlBack = null;
            this.skinPanel1.Size = new System.Drawing.Size(591, 371);
            this.skinPanel1.TabIndex = 1;
            // 
            // picbox_Captcha
            // 
            this.picbox_Captcha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picbox_Captcha.Location = new System.Drawing.Point(413, 214);
            this.picbox_Captcha.Margin = new System.Windows.Forms.Padding(4);
            this.picbox_Captcha.Name = "picbox_Captcha";
            this.picbox_Captcha.Size = new System.Drawing.Size(90, 36);
            this.picbox_Captcha.TabIndex = 17;
            this.picbox_Captcha.TabStop = false;
            this.picbox_Captcha.Click += new System.EventHandler(this.picbox_Captcha_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("楷体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(71, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 38);
            this.label4.TabIndex = 16;
            this.label4.Text = "验证码：";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtbox_Captcha
            // 
            this.txtbox_Captcha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbox_Captcha.BackColor = System.Drawing.Color.Transparent;
            this.txtbox_Captcha.DownBack = null;
            this.txtbox_Captcha.Icon = null;
            this.txtbox_Captcha.IconIsButton = false;
            this.txtbox_Captcha.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtbox_Captcha.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtbox_Captcha.IsPasswordChat = '\0';
            this.txtbox_Captcha.IsSystemPasswordChar = false;
            this.txtbox_Captcha.Lines = new string[0];
            this.txtbox_Captcha.Location = new System.Drawing.Point(197, 214);
            this.txtbox_Captcha.Margin = new System.Windows.Forms.Padding(0);
            this.txtbox_Captcha.MaxLength = 32767;
            this.txtbox_Captcha.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtbox_Captcha.MouseBack = null;
            this.txtbox_Captcha.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtbox_Captcha.Multiline = true;
            this.txtbox_Captcha.Name = "txtbox_Captcha";
            this.txtbox_Captcha.NormlBack = null;
            this.txtbox_Captcha.Padding = new System.Windows.Forms.Padding(5);
            this.txtbox_Captcha.ReadOnly = false;
            this.txtbox_Captcha.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtbox_Captcha.Size = new System.Drawing.Size(202, 36);
            // 
            // 
            // 
            this.txtbox_Captcha.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_Captcha.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbox_Captcha.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtbox_Captcha.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtbox_Captcha.SkinTxt.Multiline = true;
            this.txtbox_Captcha.SkinTxt.Name = "BaseText";
            this.txtbox_Captcha.SkinTxt.Size = new System.Drawing.Size(192, 26);
            this.txtbox_Captcha.SkinTxt.TabIndex = 0;
            this.txtbox_Captcha.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtbox_Captcha.SkinTxt.WaterText = "";
            this.txtbox_Captcha.TabIndex = 3;
            this.txtbox_Captcha.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtbox_Captcha.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtbox_Captcha.WaterText = "";
            this.txtbox_Captcha.WordWrap = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(3, 343);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "           ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // skinButton1
            // 
            this.skinButton1.BackColor = System.Drawing.Color.Transparent;
            this.skinButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.skinButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton1.DownBack = null;
            this.skinButton1.Location = new System.Drawing.Point(491, 332);
            this.skinButton1.MouseBack = null;
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.NormlBack = null;
            this.skinButton1.Size = new System.Drawing.Size(100, 39);
            this.skinButton1.TabIndex = 13;
            this.skinButton1.Text = "重置";
            this.skinButton1.UseVisualStyleBackColor = false;
            this.skinButton1.Click += new System.EventHandler(this.skinButton1_Click);
            // 
            // skinButton3
            // 
            this.skinButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.skinButton3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.skinButton3.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.skinButton3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.skinButton3.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton3.DownBack = null;
            this.skinButton3.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinButton3.Location = new System.Drawing.Point(166, 302);
            this.skinButton3.MouseBack = null;
            this.skinButton3.Name = "skinButton3";
            this.skinButton3.NormlBack = null;
            this.skinButton3.Size = new System.Drawing.Size(260, 47);
            this.skinButton3.TabIndex = 12;
            this.skinButton3.Text = "登录";
            this.skinButton3.UseVisualStyleBackColor = false;
            this.skinButton3.Click += new System.EventHandler(this.skinButton3_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(120, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 38);
            this.label2.TabIndex = 11;
            this.label2.Text = "   ";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(120, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 38);
            this.label1.TabIndex = 10;
            this.label1.Text = "   ";
            // 
            // txtbox_Passwd
            // 
            this.txtbox_Passwd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbox_Passwd.BackColor = System.Drawing.Color.Transparent;
            this.txtbox_Passwd.DownBack = null;
            this.txtbox_Passwd.Icon = null;
            this.txtbox_Passwd.IconIsButton = false;
            this.txtbox_Passwd.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtbox_Passwd.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtbox_Passwd.IsPasswordChat = '*';
            this.txtbox_Passwd.IsSystemPasswordChar = false;
            this.txtbox_Passwd.Lines = new string[0];
            this.txtbox_Passwd.Location = new System.Drawing.Point(197, 148);
            this.txtbox_Passwd.Margin = new System.Windows.Forms.Padding(0);
            this.txtbox_Passwd.MaxLength = 32767;
            this.txtbox_Passwd.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtbox_Passwd.MouseBack = null;
            this.txtbox_Passwd.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtbox_Passwd.Multiline = true;
            this.txtbox_Passwd.Name = "txtbox_Passwd";
            this.txtbox_Passwd.NormlBack = null;
            this.txtbox_Passwd.Padding = new System.Windows.Forms.Padding(5);
            this.txtbox_Passwd.ReadOnly = false;
            this.txtbox_Passwd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtbox_Passwd.Size = new System.Drawing.Size(202, 36);
            // 
            // 
            // 
            this.txtbox_Passwd.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_Passwd.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbox_Passwd.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtbox_Passwd.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtbox_Passwd.SkinTxt.Multiline = true;
            this.txtbox_Passwd.SkinTxt.Name = "BaseText";
            this.txtbox_Passwd.SkinTxt.PasswordChar = '*';
            this.txtbox_Passwd.SkinTxt.Size = new System.Drawing.Size(192, 26);
            this.txtbox_Passwd.SkinTxt.TabIndex = 0;
            this.txtbox_Passwd.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtbox_Passwd.SkinTxt.WaterText = "";
            this.txtbox_Passwd.TabIndex = 2;
            this.txtbox_Passwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtbox_Passwd.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtbox_Passwd.WaterText = "";
            this.txtbox_Passwd.WordWrap = true;
            // 
            // txtbox_UserName
            // 
            this.txtbox_UserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbox_UserName.BackColor = System.Drawing.Color.Transparent;
            this.txtbox_UserName.DownBack = null;
            this.txtbox_UserName.Icon = null;
            this.txtbox_UserName.IconIsButton = false;
            this.txtbox_UserName.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtbox_UserName.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtbox_UserName.IsPasswordChat = '\0';
            this.txtbox_UserName.IsSystemPasswordChar = false;
            this.txtbox_UserName.Lines = new string[0];
            this.txtbox_UserName.Location = new System.Drawing.Point(197, 77);
            this.txtbox_UserName.Margin = new System.Windows.Forms.Padding(0);
            this.txtbox_UserName.MaxLength = 32767;
            this.txtbox_UserName.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtbox_UserName.MouseBack = null;
            this.txtbox_UserName.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtbox_UserName.Multiline = true;
            this.txtbox_UserName.Name = "txtbox_UserName";
            this.txtbox_UserName.NormlBack = null;
            this.txtbox_UserName.Padding = new System.Windows.Forms.Padding(5);
            this.txtbox_UserName.ReadOnly = false;
            this.txtbox_UserName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtbox_UserName.Size = new System.Drawing.Size(202, 33);
            // 
            // 
            // 
            this.txtbox_UserName.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_UserName.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbox_UserName.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtbox_UserName.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtbox_UserName.SkinTxt.Multiline = true;
            this.txtbox_UserName.SkinTxt.Name = "BaseText";
            this.txtbox_UserName.SkinTxt.Size = new System.Drawing.Size(192, 23);
            this.txtbox_UserName.SkinTxt.TabIndex = 0;
            this.txtbox_UserName.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtbox_UserName.SkinTxt.WaterText = "";
            this.txtbox_UserName.TabIndex = 1;
            this.txtbox_UserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtbox_UserName.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtbox_UserName.WaterText = "";
            this.txtbox_UserName.WordWrap = true;
            // 
            // FrmLogin
            // 
            this.AcceptButton = this.skinButton3;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(588, 497);
            this.Controls.Add(this.skinPictureBox1);
            this.Controls.Add(this.skinPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuperMarket";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmLogin_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmLogin_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox1)).EndInit();
            this.skinPanel1.ResumeLayout(false);
            this.skinPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_Captcha)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinPictureBox skinPictureBox1;
        private CCWin.SkinControl.SkinPanel skinPanel1;
        private CCWin.SkinControl.SkinButton skinButton1;
        private CCWin.SkinControl.SkinButton skinButton3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CCWin.SkinControl.SkinTextBox txtbox_Passwd;
        private CCWin.SkinControl.SkinTextBox txtbox_UserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private CCWin.SkinControl.SkinTextBox txtbox_Captcha;
        private System.Windows.Forms.PictureBox picbox_Captcha;
    }
}