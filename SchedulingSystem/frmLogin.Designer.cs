namespace SchedulingSystem
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLogin = new Button();
            psw_lbl = new Label();
            txtPassword = new TextBox();
            title_lbl = new Label();
            txtAccount = new TextBox();
            acc_btn = new Label();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(182, 192);
            btnLogin.Margin = new Padding(2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(64, 25);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "登入";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // psw_lbl
            // 
            psw_lbl.AutoSize = true;
            psw_lbl.Font = new Font("微軟正黑體", 9F);
            psw_lbl.Location = new Point(114, 138);
            psw_lbl.Margin = new Padding(2, 0, 2, 0);
            psw_lbl.Name = "psw_lbl";
            psw_lbl.Size = new Size(34, 16);
            psw_lbl.TabIndex = 2;
            psw_lbl.Text = "密碼:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(151, 136);
            txtPassword.Margin = new Padding(2);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "請輸入密碼";
            txtPassword.Size = new Size(144, 23);
            txtPassword.TabIndex = 4;
            // 
            // title_lbl
            // 
            title_lbl.AutoSize = true;
            title_lbl.Font = new Font("標楷體", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title_lbl.ForeColor = SystemColors.InfoText;
            title_lbl.Location = new Point(138, 34);
            title_lbl.Margin = new Padding(2, 0, 2, 0);
            title_lbl.Name = "title_lbl";
            title_lbl.RightToLeft = RightToLeft.No;
            title_lbl.Size = new Size(160, 24);
            title_lbl.TabIndex = 5;
            title_lbl.Text = "超商排班系統";
            // 
            // txtAccount
            // 
            txtAccount.Location = new Point(151, 99);
            txtAccount.Margin = new Padding(2);
            txtAccount.Name = "txtAccount";
            txtAccount.PlaceholderText = "請輸入帳號";
            txtAccount.Size = new Size(144, 23);
            txtAccount.TabIndex = 9;
            // 
            // acc_btn
            // 
            acc_btn.AutoSize = true;
            acc_btn.Font = new Font("微軟正黑體", 9F);
            acc_btn.Location = new Point(114, 102);
            acc_btn.Margin = new Padding(2, 0, 2, 0);
            acc_btn.Name = "acc_btn";
            acc_btn.Size = new Size(34, 16);
            acc_btn.TabIndex = 8;
            acc_btn.Text = "帳號:";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(429, 263);
            Controls.Add(txtAccount);
            Controls.Add(acc_btn);
            Controls.Add(title_lbl);
            Controls.Add(txtPassword);
            Controls.Add(psw_lbl);
            Controls.Add(btnLogin);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterParent;
            Text = "超商排班系統視窗";
            Load += frmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Label psw_lbl;
        private TextBox txtPassword;
        private Label title_lbl;
        private TextBox txtAccount;
        private Label acc_btn;
    }
}
