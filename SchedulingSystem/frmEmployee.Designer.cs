namespace SchedulingSystem
{
    partial class frmEmployee
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
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "AAA", "BBB", "CCC" }, -1);
            pnlEmployeeTools = new Panel();
            button1 = new Button();
            lvEmployee = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            pnlEmployeeTools.SuspendLayout();
            SuspendLayout();
            // 
            // pnlEmployeeTools
            // 
            pnlEmployeeTools.Controls.Add(button1);
            pnlEmployeeTools.Dock = DockStyle.Top;
            pnlEmployeeTools.Location = new Point(0, 0);
            pnlEmployeeTools.Name = "pnlEmployeeTools";
            pnlEmployeeTools.Size = new Size(307, 71);
            pnlEmployeeTools.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(24, 21);
            button1.Name = "button1";
            button1.Size = new Size(92, 30);
            button1.TabIndex = 0;
            button1.Text = "新增員工";
            button1.UseVisualStyleBackColor = true;
            // 
            // lvEmployee
            // 
            lvEmployee.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lvEmployee.Dock = DockStyle.Fill;
            lvEmployee.Items.AddRange(new ListViewItem[] { listViewItem1 });
            lvEmployee.Location = new Point(0, 71);
            lvEmployee.Name = "lvEmployee";
            lvEmployee.Size = new Size(307, 190);
            lvEmployee.TabIndex = 2;
            lvEmployee.UseCompatibleStateImageBehavior = false;
            lvEmployee.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "姓名";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "帳號";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "等級";
            // 
            // frmEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(307, 261);
            Controls.Add(lvEmployee);
            Controls.Add(pnlEmployeeTools);
            Name = "frmEmployee";
            StartPosition = FormStartPosition.CenterParent;
            Text = "員工資料表";
            Load += frmEmployee_Load;
            pnlEmployeeTools.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlEmployeeTools;
        private Button button1;
        private ListView lvEmployee;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
    }
}