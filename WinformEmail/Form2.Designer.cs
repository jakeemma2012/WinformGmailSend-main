namespace WinformEmail
{
    partial class Form2
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
            this.txtGmail = new System.Windows.Forms.TextBox();
            this.labelNhapTK = new System.Windows.Forms.Label();
            this.btLogin = new System.Windows.Forms.Button();
            this.labelPass = new System.Windows.Forms.Label();
            this.labelDes = new System.Windows.Forms.Label();
            this.btRegister = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btForGetpassWord = new System.Windows.Forms.Label();
            this.labelOTP = new System.Windows.Forms.Label();
            this.txtBoxOTP = new System.Windows.Forms.TextBox();
            this.btLayMa = new System.Windows.Forms.Button();
            this.btChangeLogin = new System.Windows.Forms.Button();
            this.btChangeDangKy = new System.Windows.Forms.Button();
            this.btChangeQuenPass = new System.Windows.Forms.Button();
            this.btDangKy = new System.Windows.Forms.Button();
            this.txtBoxTypeAgainPass = new System.Windows.Forms.TextBox();
            this.labelTypeAgainPass = new System.Windows.Forms.Label();
            this.btChangePass = new System.Windows.Forms.Button();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelHaveAccount = new System.Windows.Forms.Label();
            this.btClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtGmail
            // 
            this.txtGmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGmail.Location = new System.Drawing.Point(44, 102);
            this.txtGmail.Multiline = true;
            this.txtGmail.Name = "txtGmail";
            this.txtGmail.Size = new System.Drawing.Size(207, 25);
            this.txtGmail.TabIndex = 0;
            // 
            // labelNhapTK
            // 
            this.labelNhapTK.AutoSize = true;
            this.labelNhapTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNhapTK.Location = new System.Drawing.Point(43, 82);
            this.labelNhapTK.Name = "labelNhapTK";
            this.labelNhapTK.Size = new System.Drawing.Size(84, 16);
            this.labelNhapTK.TabIndex = 1;
            this.labelNhapTK.Text = "Nhập Gmail :";
            // 
            // btLogin
            // 
            this.btLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogin.Location = new System.Drawing.Point(273, 118);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(113, 38);
            this.btLogin.TabIndex = 2;
            this.btLogin.Text = "Đăng nhập";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPass.Location = new System.Drawing.Point(41, 130);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(103, 16);
            this.labelPass.TabIndex = 4;
            this.labelPass.Text = "Nhập mật khẩu :";
            // 
            // labelDes
            // 
            this.labelDes.AutoSize = true;
            this.labelDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDes.Location = new System.Drawing.Point(80, 205);
            this.labelDes.Name = "labelDes";
            this.labelDes.Size = new System.Drawing.Size(123, 16);
            this.labelDes.TabIndex = 5;
            this.labelDes.Text = "Chưa có tài khoản ?";
            // 
            // btRegister
            // 
            this.btRegister.AutoSize = true;
            this.btRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegister.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btRegister.Location = new System.Drawing.Point(199, 205);
            this.btRegister.Name = "btRegister";
            this.btRegister.Size = new System.Drawing.Size(52, 16);
            this.btRegister.TabIndex = 6;
            this.btRegister.Text = "Đăng kí";
            this.btRegister.Click += new System.EventHandler(this.btRegister_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(44, 149);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(207, 25);
            this.txtPassword.TabIndex = 7;
            // 
            // btForGetpassWord
            // 
            this.btForGetpassWord.AutoSize = true;
            this.btForGetpassWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btForGetpassWord.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btForGetpassWord.Location = new System.Drawing.Point(155, 187);
            this.btForGetpassWord.Name = "btForGetpassWord";
            this.btForGetpassWord.Size = new System.Drawing.Size(96, 16);
            this.btForGetpassWord.TabIndex = 8;
            this.btForGetpassWord.Text = "Quên mật khẩu";
            this.btForGetpassWord.Click += new System.EventHandler(this.btForGetpassWord_Click);
            // 
            // labelOTP
            // 
            this.labelOTP.AutoSize = true;
            this.labelOTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOTP.Location = new System.Drawing.Point(250, 181);
            this.labelOTP.Name = "labelOTP";
            this.labelOTP.Size = new System.Drawing.Size(35, 16);
            this.labelOTP.TabIndex = 9;
            this.labelOTP.Text = "OTP";
            // 
            // txtBoxOTP
            // 
            this.txtBoxOTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxOTP.Location = new System.Drawing.Point(291, 176);
            this.txtBoxOTP.Multiline = true;
            this.txtBoxOTP.Name = "txtBoxOTP";
            this.txtBoxOTP.Size = new System.Drawing.Size(89, 27);
            this.txtBoxOTP.TabIndex = 10;
            // 
            // btLayMa
            // 
            this.btLayMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLayMa.Location = new System.Drawing.Point(305, 209);
            this.btLayMa.Name = "btLayMa";
            this.btLayMa.Size = new System.Drawing.Size(75, 28);
            this.btLayMa.TabIndex = 11;
            this.btLayMa.Text = "Lấy mã";
            this.btLayMa.UseVisualStyleBackColor = true;
            this.btLayMa.Click += new System.EventHandler(this.btLayMaOtp);
            // 
            // btChangeLogin
            // 
            this.btChangeLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChangeLogin.Location = new System.Drawing.Point(24, 25);
            this.btChangeLogin.Name = "btChangeLogin";
            this.btChangeLogin.Size = new System.Drawing.Size(95, 37);
            this.btChangeLogin.TabIndex = 12;
            this.btChangeLogin.Text = "Đăng nhập";
            this.btChangeLogin.UseVisualStyleBackColor = true;
            this.btChangeLogin.Click += new System.EventHandler(this.button2_Click);
            // 
            // btChangeDangKy
            // 
            this.btChangeDangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChangeDangKy.Location = new System.Drawing.Point(156, 25);
            this.btChangeDangKy.Name = "btChangeDangKy";
            this.btChangeDangKy.Size = new System.Drawing.Size(95, 37);
            this.btChangeDangKy.TabIndex = 13;
            this.btChangeDangKy.Text = "Đăng ký";
            this.btChangeDangKy.UseVisualStyleBackColor = true;
            this.btChangeDangKy.Click += new System.EventHandler(this.btChangeDangKy_Click);
            // 
            // btChangeQuenPass
            // 
            this.btChangeQuenPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChangeQuenPass.Location = new System.Drawing.Point(291, 25);
            this.btChangeQuenPass.Name = "btChangeQuenPass";
            this.btChangeQuenPass.Size = new System.Drawing.Size(95, 37);
            this.btChangeQuenPass.TabIndex = 14;
            this.btChangeQuenPass.Text = "Quên MK";
            this.btChangeQuenPass.UseVisualStyleBackColor = true;
            this.btChangeQuenPass.Click += new System.EventHandler(this.btChangeQuenPass_Click);
            // 
            // btDangKy
            // 
            this.btDangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDangKy.Location = new System.Drawing.Point(273, 118);
            this.btDangKy.Name = "btDangKy";
            this.btDangKy.Size = new System.Drawing.Size(113, 38);
            this.btDangKy.TabIndex = 15;
            this.btDangKy.Text = "Đăng Ký";
            this.btDangKy.UseVisualStyleBackColor = true;
            this.btDangKy.Click += new System.EventHandler(this.btDangKy_Click);
            // 
            // txtBoxTypeAgainPass
            // 
            this.txtBoxTypeAgainPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxTypeAgainPass.Location = new System.Drawing.Point(43, 197);
            this.txtBoxTypeAgainPass.Multiline = true;
            this.txtBoxTypeAgainPass.Name = "txtBoxTypeAgainPass";
            this.txtBoxTypeAgainPass.Size = new System.Drawing.Size(208, 25);
            this.txtBoxTypeAgainPass.TabIndex = 17;
            // 
            // labelTypeAgainPass
            // 
            this.labelTypeAgainPass.AutoSize = true;
            this.labelTypeAgainPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTypeAgainPass.Location = new System.Drawing.Point(41, 178);
            this.labelTypeAgainPass.Name = "labelTypeAgainPass";
            this.labelTypeAgainPass.Size = new System.Drawing.Size(103, 16);
            this.labelTypeAgainPass.TabIndex = 16;
            this.labelTypeAgainPass.Text = "Nhập mật khẩu :";
            // 
            // btChangePass
            // 
            this.btChangePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChangePass.Location = new System.Drawing.Point(273, 118);
            this.btChangePass.Name = "btChangePass";
            this.btChangePass.Size = new System.Drawing.Size(113, 38);
            this.btChangePass.TabIndex = 18;
            this.btChangePass.Text = "Đặt lại MK";
            this.btChangePass.UseVisualStyleBackColor = true;
            this.btChangePass.Click += new System.EventHandler(this.btChangePass_Click);
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelLogin.Location = new System.Drawing.Point(179, 205);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(72, 16);
            this.labelLogin.TabIndex = 20;
            this.labelLogin.Text = "Đăng nhập";
            this.labelLogin.Click += new System.EventHandler(this.labelLogin_Click);
            // 
            // labelHaveAccount
            // 
            this.labelHaveAccount.AutoSize = true;
            this.labelHaveAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHaveAccount.Location = new System.Drawing.Point(70, 205);
            this.labelHaveAccount.Name = "labelHaveAccount";
            this.labelHaveAccount.Size = new System.Drawing.Size(109, 16);
            this.labelHaveAccount.TabIndex = 19;
            this.labelHaveAccount.Text = "Đã có tài khoản ?";
            // 
            // btClear
            // 
            this.btClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClear.Location = new System.Drawing.Point(311, 79);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(75, 28);
            this.btClear.TabIndex = 21;
            this.btClear.Text = "Clear All";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 258);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.labelHaveAccount);
            this.Controls.Add(this.btChangePass);
            this.Controls.Add(this.txtBoxTypeAgainPass);
            this.Controls.Add(this.labelTypeAgainPass);
            this.Controls.Add(this.btDangKy);
            this.Controls.Add(this.btChangeQuenPass);
            this.Controls.Add(this.btChangeDangKy);
            this.Controls.Add(this.btChangeLogin);
            this.Controls.Add(this.btLayMa);
            this.Controls.Add(this.txtBoxOTP);
            this.Controls.Add(this.labelOTP);
            this.Controls.Add(this.btForGetpassWord);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btRegister);
            this.Controls.Add(this.labelDes);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.labelNhapTK);
            this.Controls.Add(this.txtGmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.button2_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGmail;
        private System.Windows.Forms.Label labelNhapTK;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.Label labelDes;
        private System.Windows.Forms.Label btRegister;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label btForGetpassWord;
        private System.Windows.Forms.Label labelOTP;
        private System.Windows.Forms.TextBox txtBoxOTP;
        private System.Windows.Forms.Button btLayMa;
        private System.Windows.Forms.Button btChangeLogin;
        private System.Windows.Forms.Button btChangeDangKy;
        private System.Windows.Forms.Button btChangeQuenPass;
        private System.Windows.Forms.Button btDangKy;
        private System.Windows.Forms.TextBox txtBoxTypeAgainPass;
        private System.Windows.Forms.Label labelTypeAgainPass;
        private System.Windows.Forms.Button btChangePass;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelHaveAccount;
        private System.Windows.Forms.Button btClear;
    }
}