using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Net;
using System.Windows.Forms;
using CCWin;
using MySql.Data.MySqlClient;
using SuperMarket.UI;
namespace SuperMarket
{
    public partial class FrmLogin : CCSkinMain
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        string c;//存放验证码

        #region 窗体加载
        private void Form1_Load(object sender, EventArgs e)
        {
            //重新绘制头像框
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(skinPictureBox1.ClientRectangle);
            Region region = new Region(gp);
            skinPictureBox1.Region = region;
            gp.Dispose();
            region.Dispose();
            //加载验证码
            ShowCaptcha(); 
        }
        #endregion


        #region 登录
        private void skinButton3_Click(object sender, EventArgs e)
        {
            if (txtbox_UserName.Text == "")
            {
                MessageBox.Show("请输入用户名！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtbox_UserName.Focus();
            }
            else
            {
                if (txtbox_Passwd.Text == "")
                {
                    MessageBox.Show("请输入密码！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtbox_Passwd.Focus();
                }
                else
                {
                    if (txtbox_Captcha.Text == "")
                    {
                        MessageBox.Show("请输入验证码！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtbox_Captcha.Focus();
                    }
                    else
                    {
                        if (txtbox_Captcha.Text.ToLower() == c.ToLower())
                        {
                            MySqlConnection myconn = BaseClass.DBConn.MyConn();
                            myconn.Open();
                            string mysql = "select * from Employee where EID=@username and EPasswd=@passwd";
                            MySqlCommand mycmd = new MySqlCommand(mysql, myconn);
                            mycmd.Parameters.Add("@username", MySqlDbType.VarChar, 50).Value = txtbox_UserName.Text.Trim();
                            mycmd.Parameters.Add("@passwd", MySqlDbType.VarChar, 20).Value = txtbox_Passwd.Text.Trim();
                            MySqlDataReader mysdr = mycmd.ExecuteReader();
                            mysdr.Read();
                            if (mysdr.HasRows)
                            {
                                string qx = mysdr["EPID"].ToString().Trim();
                                mycmd.Dispose();

                                #region 获取登录用户名、登录时间、局域网IP、公网IP并存入数据库
                                //获取局域网ip（2）
                                IPAddress tempip = Dns.GetHostEntry(Dns.GetHostName()).AddressList[1];
                                //dns.resolve
                                //获取公网ip
                                string LoginPublicIP = "0.0.0.0";
                                string url = "http://www.ipip.net";
                                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                                //模拟浏览器去访问网站
                                request.KeepAlive = true;
                                request.ProtocolVersion = HttpVersion.Version11;
                                request.Method = "GET";
                                request.Accept = "*/* ";
                                request.UserAgent = "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/536.5 (KHTML, like Gecko) Chrome/19.0.1084.56 Safari/536.5";
                                request.Referer = url;
                                WebResponse response = request.GetResponse();
                                Stream strm = response.GetResponseStream();
                                StreamReader sr = new StreamReader(strm);
                                if (sr != null)
                                {
                                    string all = sr.ReadToEnd();
                                    int start = all.IndexOf("IP地址", StringComparison.Ordinal) + 42;
                                    int end = all.IndexOf("<", start, StringComparison.Ordinal);
                                    LoginPublicIP = all.Substring(start, end - start);
                                    sr.Close();
                                    //Console.WriteLine(LoginPublicIP);
                                }

                                string sql = "INSERT INTO LoginLog(LoginUserName, LoginTime, LoginPublicIP, LoginLocalIP) VALUES (@LoginUserName, @LoginTime, @LoginPublicIP, @LoginLocalIP)";
                                mycmd = new MySqlCommand(sql, myconn);
                                mycmd.Parameters.Add("@LoginUserName", MySqlDbType.VarChar, 20).Value = txtbox_UserName.Text.Trim();
                                mycmd.Parameters.Add("@LoginTime", MySqlDbType.DateTime).Value = DateTime.Now;
                                mycmd.Parameters.Add("@LoginPublicIP", MySqlDbType.VarChar, 20).Value = LoginPublicIP.ToString();//LoginPublicIP
                                mycmd.Parameters.Add("@LoginLocalIP", MySqlDbType.VarChar, 20).Value = tempip;
                                try
                                {
                                    mycmd.ExecuteNonQuery();
                                }
                                catch (Exception)
                                {
                                    //如果公网ip解析错误则记录0.0.0.0.
                                    MySqlConnection myconn1 = BaseClass.DBConn.MyConn();
                                    myconn1.Open();
                                    string sql1 = "INSERT INTO LoginLog(LoginUserName, LoginTime, LoginPublicIP, LoginLocalIP) VALUES (@LoginUserName, @LoginTime, @LoginPublicIP, @LoginLocalIP)";
                                    MySqlCommand mycmd1 = new MySqlCommand(sql1, myconn1);
                                    mycmd1.Parameters.Add("@LoginUserName", MySqlDbType.VarChar, 20).Value = txtbox_UserName.Text.Trim();
                                    mycmd1.Parameters.Add("@LoginTime", MySqlDbType.DateTime).Value = DateTime.Now;
                                    mycmd1.Parameters.Add("@LoginPublicIP", MySqlDbType.VarChar, 20).Value = "0.0.0.0";//LoginPublicIP
                                    mycmd1.Parameters.Add("@LoginLocalIP", MySqlDbType.VarChar, 20).Value = tempip;
                                   // MessageBox.Show("公网IP地址解析错误!", "提示", MessageBoxButtons.OK);
                                    mycmd1.Dispose();
                                    myconn1.Close();
                                }
                                //mycmd.ExecuteNonQuery();
                                #endregion

                                FrmMain main = new FrmMain();
                                main.UserName = txtbox_UserName.Text;
                                main.Power = qx;
                                main.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("您输入的用户名或密码错误！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning); ShowCaptcha();
                                ShowCaptcha();
                                txtbox_UserName.Text = "";
                                txtbox_Passwd.Text = "";
                                txtbox_Captcha.Text = "";
                                txtbox_UserName.Focus();
                            }
                            mysdr.Close();
                            myconn.Close();
                        }
                        else
                        {
                            MessageBox.Show("您输入的验证码错误！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            ShowCaptcha();
                            //txtbox_UserName.Text = "";
                            //txtbox_Passwd.Text = "";
                            txtbox_Captcha.Text = "";
                            //txtbox_UserName.Focus();
                        }
                    }
                }
            }
        }
        #endregion

        #region 点击重置按钮
        private void skinButton1_Click(object sender, EventArgs e)
        {
            txtbox_UserName.Text = "";
            txtbox_Passwd.Text = "";
            txtbox_Captcha.Text = "";
            ShowCaptcha();
        }
        #endregion

        #region 找回密码
        private void label3_Click(object sender, EventArgs e)
        {
            FrmForget forget = new FrmForget();
            forget.Show();
            this.Hide();
        }
        #endregion

        #region 点击验证码刷新
        private void picbox_Captcha_Click(object sender, EventArgs e)
        {
            ShowCaptcha();
        }
        #endregion

        #region 生成验证码
        private string GetCaptcha()
        {
            string[] ch = new string[62];//存放数字和字母
            //设置数字
            for (int i = 0; i < 10; i++)
            {
                ch[i] = i.ToString();
            }
            //设置字母
            for (int i = 10; i < 36; i++)
            {
                ch[i] = ((char)(55 + i)).ToString();
            }
            for (int i = 36; i < ch.Length; i++)
            {
                ch[i] = ((char)(61 + i)).ToString();
            }

            Random r = new Random();
            string captcha = "";
            for (int i = 1; i <= 4; i++)
            {
                int n = r.Next(0, ch.Length);//获取数组的随机下标
                captcha += ch[n];
            }
            return captcha;
        }
        #endregion

        #region 显示/刷新验证码
        private void ShowCaptcha()
        {
            //创建一个位图对象
            Bitmap b = new Bitmap(picbox_Captcha.Width, picbox_Captcha.Height);
            //得到此图片上的画布对象
            Graphics g = Graphics.FromImage(b);
            //设置图片的背景颜色
            g.Clear(Color.White);
            c = GetCaptcha();
            g.DrawString(c, new Font("宋体", 18), Brushes.Green, new PointF(10, 2));
            picbox_Captcha.Image = b;
        }
        #endregion

        #region 按下esc退出
        private void FrmLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                Environment.Exit(0);
            }
        }
        #endregion

        #region 窗体关闭 程序结束运行
        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        #endregion
    }
}