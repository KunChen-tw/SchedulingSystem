using CalendarControlLibrary;

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
            pnlTools = new Panel();
            btnNextMonth = new Button();
            btnLastMonth = new Button();
            grpEmployeeInfo = new GroupBox();
            lblEmployeeJobGTitle = new Label();
            lblEmployeeJobGTitleLabel = new Label();
            lblEmployeeName = new Label();
            lblEmployeeNameLabel = new Label();
            pnlCalendar = new Panel();
            calMain = new CalendarControl();
            mnsMain.SuspendLayout();
            pnlTools.SuspendLayout();
            grpEmployeeInfo.SuspendLayout();
            pnlCalendar.SuspendLayout();
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
            // pnlTools
            // 
            pnlTools.Controls.Add(btnNextMonth);
            pnlTools.Controls.Add(btnLastMonth);
            pnlTools.Controls.Add(grpEmployeeInfo);
            pnlTools.Dock = DockStyle.Top;
            pnlTools.Location = new Point(0, 24);
            pnlTools.Name = "pnlTools";
            pnlTools.Size = new Size(800, 57);
            pnlTools.TabIndex = 1;
            // 
            // btnNextMonth
            // 
            btnNextMonth.Font = new Font("微軟正黑體", 12F, FontStyle.Bold, GraphicsUnit.Point, 136);
            btnNextMonth.Location = new Point(635, 13);
            btnNextMonth.Name = "btnNextMonth";
            btnNextMonth.Size = new Size(75, 33);
            btnNextMonth.TabIndex = 6;
            btnNextMonth.Text = "下個月";
            btnNextMonth.UseVisualStyleBackColor = true;
            btnNextMonth.Click += btnNextMonth_Click;
            // 
            // btnLastMonth
            // 
            btnLastMonth.Font = new Font("微軟正黑體", 12F, FontStyle.Bold, GraphicsUnit.Point, 136);
            btnLastMonth.Location = new Point(554, 13);
            btnLastMonth.Name = "btnLastMonth";
            btnLastMonth.Size = new Size(75, 33);
            btnLastMonth.TabIndex = 5;
            btnLastMonth.Text = "上個月";
            btnLastMonth.UseVisualStyleBackColor = true;
            btnLastMonth.Click += btnLastMonth_Click;
            // 
            // grpEmployeeInfo
            // 
            grpEmployeeInfo.Controls.Add(lblEmployeeJobGTitle);
            grpEmployeeInfo.Controls.Add(lblEmployeeJobGTitleLabel);
            grpEmployeeInfo.Controls.Add(lblEmployeeName);
            grpEmployeeInfo.Controls.Add(lblEmployeeNameLabel);
            grpEmployeeInfo.Dock = DockStyle.Left;
            grpEmployeeInfo.Location = new Point(0, 0);
            grpEmployeeInfo.Name = "grpEmployeeInfo";
            grpEmployeeInfo.Size = new Size(293, 57);
            grpEmployeeInfo.TabIndex = 4;
            grpEmployeeInfo.TabStop = false;
            grpEmployeeInfo.Text = "職員訊息";
            // 
            // lblEmployeeJobGTitle
            // 
            lblEmployeeJobGTitle.AutoSize = true;
            lblEmployeeJobGTitle.Font = new Font("微軟正黑體", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 136);
            lblEmployeeJobGTitle.Location = new Point(73, 22);
            lblEmployeeJobGTitle.Name = "lblEmployeeJobGTitle";
            lblEmployeeJobGTitle.Size = new Size(48, 24);
            lblEmployeeJobGTitle.TabIndex = 7;
            lblEmployeeJobGTitle.Text = "職員";
            // 
            // lblEmployeeJobGTitleLabel
            // 
            lblEmployeeJobGTitleLabel.AutoSize = true;
            lblEmployeeJobGTitleLabel.Font = new Font("微軟正黑體", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 136);
            lblEmployeeJobGTitleLabel.Location = new Point(10, 22);
            lblEmployeeJobGTitleLabel.Name = "lblEmployeeJobGTitleLabel";
            lblEmployeeJobGTitleLabel.Size = new Size(67, 24);
            lblEmployeeJobGTitleLabel.TabIndex = 6;
            lblEmployeeJobGTitleLabel.Text = "職稱：";
            // 
            // lblEmployeeName
            // 
            lblEmployeeName.AutoSize = true;
            lblEmployeeName.Font = new Font("微軟正黑體", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 136);
            lblEmployeeName.Location = new Point(200, 22);
            lblEmployeeName.Name = "lblEmployeeName";
            lblEmployeeName.Size = new Size(48, 24);
            lblEmployeeName.TabIndex = 5;
            lblEmployeeName.Text = "張三";
            // 
            // lblEmployeeNameLabel
            // 
            lblEmployeeNameLabel.AutoSize = true;
            lblEmployeeNameLabel.Font = new Font("微軟正黑體", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 136);
            lblEmployeeNameLabel.Location = new Point(137, 22);
            lblEmployeeNameLabel.Name = "lblEmployeeNameLabel";
            lblEmployeeNameLabel.Size = new Size(67, 24);
            lblEmployeeNameLabel.TabIndex = 4;
            lblEmployeeNameLabel.Text = "姓名：";
            // 
            // pnlCalendar
            // 
            pnlCalendar.Controls.Add(calMain);
            pnlCalendar.Dock = DockStyle.Fill;
            pnlCalendar.Location = new Point(0, 81);
            pnlCalendar.Name = "pnlCalendar";
            pnlCalendar.Size = new Size(800, 369);
            pnlCalendar.TabIndex = 2;
            // 
            // calMain
            // 
            calMain.Dock = DockStyle.Fill;
            calMain.Location = new Point(0, 0);
            calMain.Name = "calMain";
            calMain.Size = new Size(800, 369);
            calMain.TabIndex = 0;
            calMain.DateClicked += calMain_DateClicked;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlCalendar);
            Controls.Add(pnlTools);
            Controls.Add(mnsMain);
            MainMenuStrip = mnsMain;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "超商排班系統";
            Load += frmMain_Load;
            mnsMain.ResumeLayout(false);
            mnsMain.PerformLayout();
            pnlTools.ResumeLayout(false);
            grpEmployeeInfo.ResumeLayout(false);
            grpEmployeeInfo.PerformLayout();
            pnlCalendar.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnsMain;
        private ToolStripMenuItem tsmiFile;
        private ToolStripMenuItem tsmiHelp;
        private ToolStripMenuItem tsmiEmployee;
        private ToolStripMenuItem tsmiQueryEmployee;
        private Panel pnlTools;
        private Panel pnlCalendar;
        private CalendarControlLibrary.CalendarControl calMain;
        private GroupBox grpEmployeeInfo;
        private Label lblEmployeeJobGTitle;
        private Label lblEmployeeJobGTitleLabel;
        private Label lblEmployeeName;
        private Label lblEmployeeNameLabel;
        private Button btnNextMonth;
        private Button btnLastMonth;
    }

}