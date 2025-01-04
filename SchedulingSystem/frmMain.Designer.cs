namespace SchedulingSystem
{

    partial class frmMain
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
            mnsMain = new MenuStrip();
            tsmiFile = new ToolStripMenuItem();
            tsmiEmployee = new ToolStripMenuItem();
            tsmiQueryEmployee = new ToolStripMenuItem();
            tsmiHelp = new ToolStripMenuItem();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            mnsMain.SuspendLayout();
            SuspendLayout();
            // 
            // mnsMain
            // 
            mnsMain.Items.AddRange(new ToolStripItem[] { tsmiFile, tsmiEmployee, tsmiHelp });
            mnsMain.Location = new Point(0, 0);
            mnsMain.Name = "mnsMain";
            mnsMain.Size = new Size(800, 24);
            mnsMain.TabIndex = 0;
            mnsMain.Text = "menuStrip1";
            // 
            // tsmiFile
            // 
            tsmiFile.Name = "tsmiFile";
            tsmiFile.Size = new Size(57, 20);
            tsmiFile.Text = "檔案(&F)";
            // 
            // tsmiEmployee
            // 
            tsmiEmployee.DropDownItems.AddRange(new ToolStripItem[] { tsmiQueryEmployee });
            tsmiEmployee.Name = "tsmiEmployee";
            tsmiEmployee.Size = new Size(67, 20);
            tsmiEmployee.Text = "員工資料";
            tsmiEmployee.Visible = false;
            // 
            // tsmiQueryEmployee
            // 
            tsmiQueryEmployee.Name = "tsmiQueryEmployee";
            tsmiQueryEmployee.Size = new Size(98, 22);
            tsmiQueryEmployee.Text = "查詢";
            tsmiQueryEmployee.Click += tsmiQueryEmployee_Click;
            // 
            // tsmiHelp
            // 
            tsmiHelp.Name = "tsmiHelp";
            tsmiHelp.Size = new Size(60, 20);
            tsmiHelp.Text = "說明(&H)";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8 });
            listView1.Font = new Font("微軟正黑體", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            listView1.Location = new Point(25, 49);
            listView1.Name = "listView1";
            listView1.Size = new Size(733, 357);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "員工姓名";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "SUN";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "MON";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "TUE";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "WED";
            columnHeader5.TextAlign = HorizontalAlignment.Center;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "THU";
            columnHeader6.TextAlign = HorizontalAlignment.Center;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "FRI";
            columnHeader7.TextAlign = HorizontalAlignment.Center;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "SAT";
            columnHeader8.TextAlign = HorizontalAlignment.Center;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listView1);
            Controls.Add(mnsMain);
            MainMenuStrip = mnsMain;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "超商排班系統";
            Load += frmMain_Load;
            mnsMain.ResumeLayout(false);
            mnsMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnsMain;
        private ToolStripMenuItem tsmiFile;
        private ToolStripMenuItem tsmiHelp;
        private ToolStripMenuItem tsmiEmployee;
        private ToolStripMenuItem tsmiQueryEmployee;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
    }

}