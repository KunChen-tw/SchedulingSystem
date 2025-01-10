namespace SchedulingSystem
{
    partial class frmDayShift
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
            shiftAfternoon = new SchedulingControlLibrary.ShiftControl();
            shiftMorning = new SchedulingControlLibrary.ShiftControl();
            shiftNight = new SchedulingControlLibrary.ShiftControl();
            shiftGraveyard = new SchedulingControlLibrary.ShiftControl();
            shiftOff = new SchedulingControlLibrary.ShiftControl();
            lblDay = new Label();
            btnOK = new Button();
            SuspendLayout();
            // 
            // shiftAfternoon
            // 
            shiftAfternoon.BackColor = Color.DarkGreen;
            shiftAfternoon.IsSelected = false;
            shiftAfternoon.Location = new Point(168, 58);
            shiftAfternoon.Name = "shiftAfternoon";
            shiftAfternoon.Size = new Size(150, 150);
            shiftAfternoon.TabIndex = 4;
            shiftAfternoon.Type = Shift.ShiftType.Afternoon;
            // 
            // shiftMorning
            // 
            shiftMorning.BackColor = Color.DarkBlue;
            shiftMorning.IsSelected = false;
            shiftMorning.Location = new Point(12, 58);
            shiftMorning.Name = "shiftMorning";
            shiftMorning.Size = new Size(150, 150);
            shiftMorning.TabIndex = 5;
            shiftMorning.Type = Shift.ShiftType.Morning;
            // 
            // shiftNight
            // 
            shiftNight.BackColor = Color.DarkRed;
            shiftNight.IsSelected = false;
            shiftNight.Location = new Point(324, 58);
            shiftNight.Name = "shiftNight";
            shiftNight.Size = new Size(150, 150);
            shiftNight.TabIndex = 6;
            shiftNight.Type = Shift.ShiftType.Night;
            // 
            // shiftGraveyard
            // 
            shiftGraveyard.BackColor = Color.DarkOrange;
            shiftGraveyard.IsSelected = false;
            shiftGraveyard.Location = new Point(12, 229);
            shiftGraveyard.Name = "shiftGraveyard";
            shiftGraveyard.Size = new Size(150, 150);
            shiftGraveyard.TabIndex = 7;
            shiftGraveyard.Type = Shift.ShiftType.Graveyard;
            // 
            // shiftOff
            // 
            shiftOff.BackColor = Color.DarkGray;
            shiftOff.IsSelected = false;
            shiftOff.Location = new Point(168, 229);
            shiftOff.Name = "shiftOff";
            shiftOff.Size = new Size(150, 150);
            shiftOff.TabIndex = 7;
            shiftOff.Type = Shift.ShiftType.Off;
            // 
            // lblDay
            // 
            lblDay.AutoSize = true;
            lblDay.Font = new Font("微軟正黑體", 12F, FontStyle.Bold, GraphicsUnit.Point, 136);
            lblDay.Location = new Point(23, 18);
            lblDay.Name = "lblDay";
            lblDay.Size = new Size(104, 21);
            lblDay.TabIndex = 8;
            lblDay.Text = "2025-01-11";
            // 
            // btnOK
            // 
            btnOK.BackColor = Color.Lavender;
            btnOK.Font = new Font("微軟正黑體", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 136);
            btnOK.Location = new Point(359, 304);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 43);
            btnOK.TabIndex = 9;
            btnOK.Text = "確認";
            btnOK.UseVisualStyleBackColor = false;
            btnOK.Click += btnOK_Click;
            // 
            // frmDayShift
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 403);
            Controls.Add(btnOK);
            Controls.Add(lblDay);
            Controls.Add(shiftOff);
            Controls.Add(shiftGraveyard);
            Controls.Add(shiftNight);
            Controls.Add(shiftMorning);
            Controls.Add(shiftAfternoon);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmDayShift";
            StartPosition = FormStartPosition.CenterParent;
            Text = "請選擇班別";
            Load += frmDayShift_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlMorning;
        private Panel pnlShiftMorning;
        private Label lblShiftDescription;
        private CheckBox chkMorningSelect;
        private RichTextBox txtShiftNote;
        private Panel pnlAfternoon;
        private Panel pnlShiftAfternoon;
        private Label lblShiftAfternoon;
        private CheckBox checkBox1;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private SchedulingControlLibrary.ShiftControl shiftAfternoon;
        private SchedulingControlLibrary.ShiftControl shiftMorning;
        private SchedulingControlLibrary.ShiftControl shiftNight;
        private SchedulingControlLibrary.ShiftControl shiftGraveyard;
        private SchedulingControlLibrary.ShiftControl shiftOff;
        private Label lblDay;
        private Button btnOK;
    }
}