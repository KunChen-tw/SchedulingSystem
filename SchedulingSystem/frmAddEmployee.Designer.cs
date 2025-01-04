namespace 排班系統
{
    partial class frmAddEmployee
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
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnSave = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("微軟正黑體", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label3.Location = new Point(124, 240);
            label3.Name = "label3";
            label3.Size = new Size(48, 22);
            label3.TabIndex = 2;
            label3.Text = "密碼:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("微軟正黑體", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label4.Location = new Point(124, 128);
            label4.Name = "label4";
            label4.Size = new Size(48, 22);
            label4.TabIndex = 3;
            label4.Text = "名字:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            label4.Click += label4_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(171, 179);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(162, 27);
            textBox1.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(171, 125);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(162, 27);
            textBox3.TabIndex = 6;
            textBox3.UseSystemPasswordChar = true;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(171, 237);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(162, 27);
            textBox4.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("微軟正黑體", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.Location = new Point(124, 182);
            label1.Name = "label1";
            label1.Size = new Size(48, 22);
            label1.TabIndex = 0;
            label1.Text = "帳號:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("標楷體", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label2.Location = new Point(147, 46);
            label2.Name = "label2";
            label2.Size = new Size(186, 28);
            label2.TabIndex = 8;
            label2.Text = "員工資料建檔";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(201, 311);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(84, 31);
            btnSave.TabIndex = 9;
            btnSave.Text = "存檔";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(485, 378);
            Controls.Add(btnSave);
            Controls.Add(label2);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "Form4";
            Text = "新增員工";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label1;
        private Label label2;
        private Button btnSave;
    }
}