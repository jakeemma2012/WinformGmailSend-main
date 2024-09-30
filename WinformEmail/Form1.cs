using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformEmail
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtClear_Click(object sender, EventArgs e)
        {
            txtEmail.Clear();
            txtCaption.Clear();
            txtMessage.Clear();
        }

        private void btSend_Click(object sender, EventArgs e)
        {

            if (isValidTyping())
            {
                if (isValidEmail(Form2.stringGmail))
                {
                    if (isValidEmail(txtEmail.Text.Trim()))
                    {
                        setOnOffButton(false);
                        emailSend();
                    }
                    else
                    {
                        MessageBox.Show("Email is not Valid", "Erorr", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Email Send is not Valid", "Erorr", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Please Typing The Email Fisrt !");
            }
        }

        void emailSend()
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(Form2.stringGmail.Trim());
                mail.To.Add(txtEmail.Text.Trim());
                mail.Subject = txtCaption.Text;
                mail.Body = txtMessage.Text;

                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
                smtpClient.EnableSsl = true;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential("laovanleuhoho@gmail.com", "dokt kayj hsqx xcvw");

                smtpClient.Send(mail);
                MessageBox.Show("Send SuccessFul to " + txtEmail.Text.Trim());
                txtClear.Visible = true;
            }
            catch (SmtpException ex)
            {
                MessageBox.Show($"SmtpException: {ex.Message}");
                MessageBox.Show($"StatusCode: {ex.StatusCode}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"General Exception: {ex.Message}");
            }
            finally
            {
                setOnOffButton(true);
            }
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

        bool isValidTyping()
        {
            return txtEmail.Text.Trim() != "" && txtCaption.Text.Trim() != "" && txtMessage.Text.Trim() != "";
        }

        void setOnOffButton(bool typeset)
        {
            txtEmail.Enabled = typeset;
            txtCaption.Enabled = typeset;
            txtMessage.Enabled = typeset;

            btSend.Enabled = typeset;
        }

        string configStringConnectDTB = "Server=14.225.203.143;Database=jaki;User ID=root;Password=ZSYfN9YRBACa2Rnp;";
        MySqlConnection conn = null;

        void ConnectDTB()
        {
            conn = new MySqlConnection(configStringConnectDTB);
            try
            {
                conn.Open();
                MessageBox.Show("DataBase Has Get Ready !");
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

        private void btConnectDTB_Click_1(object sender, EventArgs e)
        {
            ConnectDTB();
        }
    }
}
