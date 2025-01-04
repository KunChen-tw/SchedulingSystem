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
            tsmiQueryEmployee.Size = new Size(180, 22);
            tsmiQueryEmployee.Text = "查詢";
            tsmiQueryEmployee.Click += tsmiQueryEmployee_Click;
            // 
            // tsmiHelp
            // 
            tsmiHelp.Name = "tsmiHelp";
            tsmiHelp.Size = new Size(60, 20);
            tsmiHelp.Text = "說明(&H)";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }

}