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
            lblPassword = new Label();
            txtPassword = new TextBox();
            title_lbl = new Label();
            txtAccount = new TextBox();
            lblAccount = new Label();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Lavender;
            btnLogin.Font = new Font("微軟正黑體", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 136);
            btnLogin.Location = new Point(159, 181);
            btnLogin.Margin = new Padding(2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(114, 57);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "登入";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("微軟正黑體", 14.25F, FontStyle.Bold);
            lblPassword.Location = new Point(104, 136);
            lblPassword.Margin = new Padding(2, 0, 2, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(53, 24);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "密碼:";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Consolas", 14.25F);
            txtPassword.Location = new Point(173, 133);
            txtPassword.Margin = new Padding(2);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "請輸入密碼";
            txtPassword.Size = new Size(144, 30);
            txtPassword.TabIndex = 4;
            txtPassword.Text = "123";
            // 
            // title_lbl
            // 
            title_lbl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            title_lbl.AutoSize = true;
            title_lbl.Font = new Font("標楷體", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title_lbl.ForeColor = Color.RoyalBlue;
            title_lbl.Location = new Point(134, 32);
            title_lbl.Margin = new Padding(2, 0, 2, 0);
            title_lbl.Name = "title_lbl";
            title_lbl.RightToLeft = RightToLeft.No;
            title_lbl.Size = new Size(160, 24);
            title_lbl.TabIndex = 5;
            title_lbl.Text = "超商排班系統";
            // 
            // txtAccount
            // 
            txtAccount.Font = new Font("Consolas", 14.25F);
            txtAccount.Location = new Point(173, 96);
            txtAccount.Margin = new Padding(2);
            txtAccount.Name = "txtAccount";
            txtAccount.PlaceholderText = "請輸入帳號";
            txtAccount.Size = new Size(144, 30);
            txtAccount.TabIndex = 9;
            txtAccount.Text = "aaa";
            // 
            // lblAccount
            // 
            lblAccount.AutoSize = true;
            lblAccount.Font = new Font("微軟正黑體", 14.25F, FontStyle.Bold);
            lblAccount.Location = new Point(104, 99);
            lblAccount.Margin = new Padding(2, 0, 2, 0);
            lblAccount.Name = "lblAccount";
            lblAccount.Size = new Size(53, 24);
            lblAccount.TabIndex = 8;
            lblAccount.Text = "帳號:";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(429, 263);
            Controls.Add(txtAccount);
            Controls.Add(lblAccount);
            Controls.Add(title_lbl);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(btnLogin);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterParent;
            Text = "超商排班系統視窗";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Label lblPassword;
        private TextBox txtPassword;
        private Label title_lbl;
        private TextBox txtAccount;
        private Label lblAccount;
    }
}
