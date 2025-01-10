namespace SchedulingControlLibrary
{
    partial class ShiftControl
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            pnlShift = new Panel();
            txtNote = new RichTextBox();
            pnlShiftAfternoon = new Panel();
            chkSelect = new CheckBox();
            lblShiftDescription = new Label();
            pnlShift.SuspendLayout();
            pnlShiftAfternoon.SuspendLayout();
            SuspendLayout();
            // 
            // pnlShift
            // 
            pnlShift.BackColor = Color.Transparent;
            pnlShift.Controls.Add(txtNote);
            pnlShift.Controls.Add(pnlShiftAfternoon);
            pnlShift.Location = new Point(5, 4);
            pnlShift.Name = "pnlShift";
            pnlShift.Size = new Size(140, 143);
            pnlShift.TabIndex = 2;
            // 
            // txtNote
            // 
            txtNote.BackColor = Color.DarkRed;
            txtNote.Dock = DockStyle.Fill;
            txtNote.Font = new Font("微軟正黑體", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtNote.ForeColor = Color.White;
            txtNote.Location = new Point(0, 42);
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(140, 101);
            txtNote.TabIndex = 11;
            txtNote.Text = "";
            // 
            // pnlShiftAfternoon
            // 
            pnlShiftAfternoon.BackColor = Color.Transparent;
            pnlShiftAfternoon.Controls.Add(chkSelect);
            pnlShiftAfternoon.Controls.Add(lblShiftDescription);
            pnlShiftAfternoon.Dock = DockStyle.Top;
            pnlShiftAfternoon.Location = new Point(0, 0);
            pnlShiftAfternoon.Name = "pnlShiftAfternoon";
            pnlShiftAfternoon.Size = new Size(140, 42);
            pnlShiftAfternoon.TabIndex = 10;
            // 
            // chkSelect
            // 
            chkSelect.AutoSize = true;
            chkSelect.Location = new Point(10, 11);
            chkSelect.Name = "chkSelect";
            chkSelect.Size = new Size(15, 14);
            chkSelect.TabIndex = 0;
            chkSelect.UseVisualStyleBackColor = true;
            // 
            // lblShiftDescription
            // 
            lblShiftDescription.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblShiftDescription.Font = new Font("微軟正黑體", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 136);
            lblShiftDescription.ForeColor = Color.White;
            lblShiftDescription.Location = new Point(10, 6);
            lblShiftDescription.Name = "lblShiftDescription";
            lblShiftDescription.Size = new Size(116, 33);
            lblShiftDescription.TabIndex = 2;
            lblShiftDescription.Text = "午班";
            lblShiftDescription.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ShiftControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkRed;
            Controls.Add(pnlShift);
            Name = "ShiftControl";
            pnlShift.ResumeLayout(false);
            pnlShiftAfternoon.ResumeLayout(false);
            pnlShiftAfternoon.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlShift;
        private Panel pnlShiftAfternoon;
        private Label lblShiftDescription;
        private CheckBox chkSelect;
        private RichTextBox txtNote;
    }
}
