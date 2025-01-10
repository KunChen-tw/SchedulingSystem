using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchedulingControlLibrary
{
    public partial class ShiftControl : UserControl
    {
        private string[] textArray;
        private Shift shift;
        public ShiftControl()
        {
            InitializeComponent();
            this.Resize += new EventHandler(ShiftControl_Resize);
            this.BackColorChanged += new EventHandler(ShiftControl_BackColorChanged);

            // Enable multiline for txtNote
            txtNote.Multiline = true;
        }

        private void ShiftControl_Resize(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                control.Width = this.Width / this.Controls.Count;
                control.Height = this.Height;
            }
        }

        private void ShiftControl_BackColorChanged(object sender, EventArgs e)
        {
            txtNote.BackColor = this.BackColor;
        }

        /// <summary>
        /// 設定或取得是否選取。
        /// </summary>
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool IsSelected
        {
            get { return chkSelect.Checked; }
            set { chkSelect.Checked = value; }
        }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public new string[] Text
        {
            get { return textArray; }
            set
            {
                textArray = value;
                txtNote.Text = string.Join(Environment.NewLine, textArray);
            }
        }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Shift.ShiftType Type
        {
            get { return shift?.Type ?? default(Shift.ShiftType); }
            set
            {
                if (shift == null)
                {
                    shift = new Shift();
                }
                shift.Type = value;
                lblShiftDescription.Text = shift.Description;
                UpdateBackColor();
            }
        }

        private void UpdateBackColor()
        {
            switch (shift.Type)
            {
                case Shift.ShiftType.Morning:
                    this.BackColor = Color.DarkBlue;
                    break;
                case Shift.ShiftType.Afternoon:
                    this.BackColor = Color.DarkGreen;
                    break;
                case Shift.ShiftType.Night:
                    this.BackColor = Color.DarkRed;
                    break;
                case Shift.ShiftType.Graveyard:
                    this.BackColor = Color.DarkOrange;
                    break;
                case Shift.ShiftType.Off:
                    this.BackColor = Color.DarkGray;
                    break;
                default:
                    this.BackColor = SystemColors.Control;
                    break;
            }
        }
    }
}
