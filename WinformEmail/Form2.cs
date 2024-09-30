using MySql.Data.MySqlClient;
using System;
using System.Net.Mail;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WinformEmail
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            SetVisible(0);
        }

        public static string stringGmail = "";
        public static string stringPassWrod = "";
        string OPTVERIFY = generateOPTrandom();
        byte typeSet = 0;
        public string configStringConnectDTB = "Server=14.225.203.143;Database=jaki;User ID=root;Password=ZSYfN9YRBACa2Rnp;";
        public MySqlConnection conn = null;

        private void btLogin_Click(object sender, EventArgs e)
        {
            if (isValidLogin())
            {
                if (isValidEmail(txtGmail.Text.Trim()))
                {
                    if (txtBoxOTP.Text.Trim().CompareTo(this.OPTVERIFY) == 0)
                    {
                        if (conn != null)
                        {
                            LoginFunc();
                        }
                        else
                        {
                            ConnectDTB();
                            LoginFunc();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mã xác nhận không đúng !", "Lỗi", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Tài khoản không đúng định dạng !", "Lỗi", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập đầy đủ thông tin !");
            }
        }


        private void btLayMaOtp(object sender, EventArgs e)
        {
            if (isValidEmail(txtGmail.Text.Trim()))
            {
                sendOTPVerify();
            }
            else
            {
                MessageBox.Show("Tài khoản không đúng định dạng !", "Lỗi", MessageBoxButtons.OK);
            }
        }

        private void btDangKy_Click(object sender, EventArgs e)
        {
            if (isValidLogin())
            {
                if (isValidEmail(txtGmail.Text.Trim()))
                {
                    if (conn != null)
                    {
                        register();
                    }
                    else
                    {
                        ConnectDTB();
                        register();
                    }
                }
            }
            else
            {
                MessageBox.Show("Hãy điền đẩy đủ thông tin để tiến hành đăng ký !");
            }
        }

        void register()
        {
            if (txtBoxOTP.Text.Trim().CompareTo(this.OPTVERIFY) == 0)  
            {
                string query = "SELECT * FROM account WHERE username = @username LIMIT 1";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", txtGmail.Text.Trim());
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    MessageBox.Show("Tài khoản đã tồn tại trên hệ thống !");
                }
                else
                {
                    reader.Close();
                    query = "INSERT INTO account (username, pass) VALUES (@username, @pass)";
                    MySqlCommand cmdInsert = new MySqlCommand(query, conn);
                    cmdInsert.Parameters.AddWithValue("@username", txtGmail.Text.Trim());
                    cmdInsert.Parameters.AddWithValue("@pass", txtPassword.Text);
                    int rowsAffected = cmdInsert.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Đăng ký thành công, Hãy quay lại trang đăng nhập !");
                    }
                    else
                    {
                        MessageBox.Show("Xảy ra lỗi trong quá trình đăng ký, hãy thử lại hoặc báo cho đội ngũ phát hành !");
                    }
                }
            } else
            {
                MessageBox.Show("Mã OPT không đúng !");
            }
        }

        private void btChangePass_Click(object sender, EventArgs e)
        {
            if (isValidRsPass())
            {
                if (isValidEmail(txtGmail.Text.Trim()))
                {
                    if (conn != null)
                    {
                        resetPass();
                    }
                    else
                    {
                        ConnectDTB();
                        resetPass();
                    }
                }
            }
            else
            {
                MessageBox.Show("Hãy điền đẩy đủ thông tin để tiến hành reset Password !");
            }
        }

        void resetPass()
        {
            if (txtPassword.Text.CompareTo(txtBoxTypeAgainPass.Text.Trim()) == 0)
            {
                if (txtBoxOTP.Text.Trim().CompareTo(this.OPTVERIFY) == 0)
                {
                    string query = "SELECT * FROM account WHERE username = @username LIMIT 1";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", txtGmail.Text.Trim());
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Close();
                        query = "UPDATE account SET pass = @password WHERE username = @username";
                        MySqlCommand cmdUpdate = new MySqlCommand(query, conn);
                        cmdUpdate.Parameters.AddWithValue("@username", txtGmail.Text.Trim());
                        cmdUpdate.Parameters.AddWithValue("@password", txtBoxTypeAgainPass.Text);
                        int rowsAffected = cmdUpdate.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cập nhật mật khẩu thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Xảy ra lỗi trong quá trình thực hiện thay đổi mật khẩu !");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản không tồn tại trên hệ thống !");
                    }
                } else{
                    MessageBox.Show("Mã OPT không đúng !");
                }
            }
            else{
                MessageBox.Show("Mật khẩu nhập lại chưa giống nhau !");
            }
        }


        void LoginFunc()
        {
            string query = "SELECT * FROM account WHERE username = @username AND pass = @password LIMIT 1";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", txtGmail.Text.Trim());
            cmd.Parameters.AddWithValue("@password", txtPassword.Text);
            MySqlDataReader reader = reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                MessageBox.Show("Đăng nhập thành công !");
                stringGmail = txtGmail.Text;
                stringPassWrod = txtPassword.Text;
                Form1 fm1 = new Form1();
                this.Hide();
                fm1.Show();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu !");
            }
            reader.Close();
        }

        bool isValidLogin()
        {
            return txtGmail.Text.Trim() != "" && txtPassword.Text.Trim() != "" && txtBoxOTP.Text.Trim() != "";
        }

        bool isValidRsPass()
        {
            return txtGmail.Text.Trim() != "" && txtPassword.Text.Trim() != "" && txtBoxOTP.Text.Trim() != "" && txtBoxTypeAgainPass.Text.Trim() != "";
        }

        bool isValidUserAndPass()
        {
            return txtGmail.Text.Trim() != "" && txtPassword.Text.Trim() != "";
        }

        bool isValidEmail(string inputEmail)
        {
            string strRegex = @"^[a-zA-Z0-9._%+-]+@gmail\.com$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputEmail))
                return (true);
            else
                return (false);
        }


        void sendOTPVerify()
        {
            string otp = generateOPTrandom();
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("laovanleuhoho@gmail.com");
                mail.To.Add(txtGmail.Text.Trim());
                mail.Subject = "GMAIL TOOL VERIRY : " + otp;
                mail.Body = "GMAIL TOOL VERIRY : " + otp;

                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
                smtpClient.EnableSsl = true;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential("laovanleuhoho@gmail.com", "dokt kayj hsqx xcvw");

                smtpClient.Send(mail);
                this.OPTVERIFY = otp;
                MessageBox.Show("Vui lòng kiểm tra mã tại Gmail : " + txtGmail.Text.Trim());
            }
            catch (SmtpException ex)
            {
                MessageBox.Show("Xảy ra lõi khi gửi OPT !", "Lỗi", MessageBoxButtons.OK);
            }
        }

        void ConnectDTB()
        {
            conn = new MySqlConnection(configStringConnectDTB);
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                DialogResult rs = MessageBox.Show("Thiết lập máy chủ thất bại!\n Bạn có muốn thử kết nối lại không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    ConnectDTB();
                }
                else
                {
                    Application.Exit();
                }
            }
        }


        static string generateOPTrandom()
        {
            Random random = new Random();
            string otp = "";
            for (int i = 0; i < 5; i++)
            {
                otp += random.Next(0, 10).ToString();
            }
            return otp;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.typeSet = 0;
            SetVisible(this.typeSet);
        }
        private void btChangeDangKy_Click(object sender, EventArgs e)
        {
            this.typeSet = 1;
            SetVisible(this.typeSet);
        }
        private void btChangeQuenPass_Click(object sender, EventArgs e)
        {
            this.typeSet = 2;
            SetVisible(this.typeSet);
        }

        private void btForGetpassWord_Click(object sender, EventArgs e)
        {
            btChangeQuenPass_Click(sender, e);
        }

        private void btRegister_Click(object sender, EventArgs e)
        {
            btChangeDangKy_Click(sender, e);
        }

        private void labelLogin_Click(object sender, EventArgs e)
        {
            button2_Click(sender, e);
        }
        private void btClear_Click(object sender, EventArgs e)
        {
            ClearALl();
        }


        void ClearALl()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox textbox)
                {
                    textbox.Clear();
                }
            }
        }

        void SetVisible(byte type)
        {
            foreach (Control control in this.Controls)
            {
                control.Visible = false;
            }
            // reset OTP to new OTP
            this.OPTVERIFY = generateOPTrandom();

            //Clear All text
            ClearALl();

            switch (type)
            {
                case 0:

                    labelNhapTK.Visible = true;
                    txtGmail.Visible = true;
                    labelPass.Visible = true;
                    txtPassword.Visible = true;
                    labelOTP.Visible = true;
                    txtBoxOTP.Visible = true;
                    btLayMa.Visible = true;
                    btLogin.Visible = true;
                    btForGetpassWord.Visible = true;
                    btRegister.Visible = true;
                    labelDes.Visible = true;
                    btChangeLogin.Visible = true;
                    btChangeDangKy.Visible = true;
                    btChangeQuenPass.Visible = true;
                    btClear.Visible = true;
                    btChangeLogin.BackColor = System.Drawing.Color.Blue;
                    btChangeDangKy.UseVisualStyleBackColor = true;
                    btChangeQuenPass.UseVisualStyleBackColor = true;
                    break;
                case 1:
                    labelNhapTK.Visible = true;
                    txtGmail.Visible = true;
                    labelPass.Visible = true;
                    txtPassword.Visible = true;
                    labelOTP.Visible = true;
                    txtBoxOTP.Visible = true;
                    btLayMa.Visible = true;
                    btDangKy.Visible = true;
                    btChangeLogin.Visible = true;
                    btChangeDangKy.Visible = true;
                    btChangeQuenPass.Visible = true;
                    btForGetpassWord.Visible = true;
                    labelLogin.Visible = true;
                    labelHaveAccount.Visible = true;
                    btClear.Visible = true;
                    btChangeLogin.UseVisualStyleBackColor = true;
                    btChangeDangKy.BackColor = System.Drawing.Color.Blue;
                    btChangeQuenPass.UseVisualStyleBackColor = true;
                    break;
                case 2:
                    labelNhapTK.Visible = true;
                    txtGmail.Visible = true;
                    labelPass.Visible = true;
                    txtPassword.Visible = true;
                    labelOTP.Visible = true;
                    txtBoxOTP.Visible = true;
                    btLayMa.Visible = true;
                    btChangeLogin.Visible = true;
                    btChangeDangKy.Visible = true;
                    btChangeQuenPass.Visible = true;
                    btChangeDangKy.Visible = true;
                    btChangeQuenPass.Visible = true;
                    labelTypeAgainPass.Visible = true;
                    txtBoxTypeAgainPass.Visible = true;
                    btChangePass.Visible = true;
                    btClear.Visible = true;
                    btChangeLogin.UseVisualStyleBackColor = true;
                    btChangeDangKy.UseVisualStyleBackColor = true;
                    btChangeQuenPass.BackColor = System.Drawing.Color.Blue;
                    break;
            }
        }
    }
}
