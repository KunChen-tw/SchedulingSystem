using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchedulingSystem
{
    public partial class frmDayShift : Form
    {
        public DateTime selectTime;
        public frmDayShift()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            bool isMorning = this.shiftMorning.IsSelected;
            bool isAfternoon = this.shiftAfternoon.IsSelected;
            bool isNight = this.shiftNight.IsSelected;
            bool isGraveyard = this.shiftGraveyard.IsSelected;
            bool isOff = this.shiftOff.IsSelected;
            if (!isMorning && !isAfternoon && !isNight && !isGraveyard && !isOff)
            {
                MessageBox.Show("請選擇班別", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string selectedShift = "";
                if (isMorning) selectedShift = "早班";
                if (isAfternoon) selectedShift = "午班";
                if (isNight) selectedShift = "晚班";
                if (isGraveyard) selectedShift = "大夜班";
                if (isOff) selectedShift = "休息";

                MessageBox.Show($"選擇的日期: {selectTime.ToString("yyyy/MM/dd")}\n選擇的班別: {selectedShift}", "班別資訊", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
        }

        private void frmDayShift_Load(object sender, EventArgs e)
        {
            lblDay.Text = selectTime.ToString("yyyy/MM/dd");    
        }
    }
}
