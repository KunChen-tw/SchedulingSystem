using System;
using System.Drawing;
using System.Windows.Forms;

namespace SchedulingSystem
{
    public partial class CalendarControl : UserControl
    {
        private DateTime currentMonth;

        public CalendarControl()
        {
            InitializeCalendar();
        }

        private void InitializeCalendar()
        {
            this.Resize += CalendarControl_Resize;
            currentMonth = DateTime.Today;
            GenerateCalendar();
        }

        private void CalendarControl_Resize(object sender, EventArgs e)
        {
            GenerateCalendar();
        }

        public void ShowPreviousMonth()
        {
            currentMonth = currentMonth.AddMonths(-1);
            GenerateCalendar();
        }

        public void ShowNextMonth()
        {
            currentMonth = currentMonth.AddMonths(1);
            GenerateCalendar();
        }

        private void GenerateCalendar()
        {
            this.Controls.Clear();

            string[] daysOfWeek = { "星期日", "星期一", "星期二", "星期三", "星期四", "星期五", "星期六" };
            int labelWidth = this.Width / 7;
            int labelHeight = this.Height / 6;

            for (int i = 0; i < 7; i++)
            {
                Label lblDayOfWeek = new Label
                {
                    Font = new Font("標楷體", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 136),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Size = new Size(labelWidth, labelHeight),
                    Location = new Point(i * labelWidth, 0),
                    Text = daysOfWeek[i]
                };
                this.Controls.Add(lblDayOfWeek);
            }

            DateTime firstDayOfMonth = new DateTime(currentMonth.Year, currentMonth.Month, 1);
            int daysInMonth = DateTime.DaysInMonth(currentMonth.Year, currentMonth.Month);
            int startDayOfWeek = (int)firstDayOfMonth.DayOfWeek;

            for (int i = 0; i < 6; i++) // 調整為6行以顯示完整的月份
            {
                for (int j = 0; j < 7; j++)
                {
                    Panel dayPanel = new Panel
                    {
                        Size = new Size(labelWidth, labelHeight),
                        Location = new Point(j * labelWidth, (i + 1) * labelHeight)
                    };

                    int dayNumber = i * 7 + j - startDayOfWeek + 1;
                    if (dayNumber > 0 && dayNumber <= daysInMonth)
                    {
                        dayPanel.BorderStyle = BorderStyle.FixedSingle;
                        Label lblDate = new Label
                        {
                            Text = $"{currentMonth.Month}/{dayNumber}",
                            TextAlign = ContentAlignment.TopRight,
                            Dock = DockStyle.Top,
                            ForeColor = dayNumber == DateTime.Today.Day && currentMonth.Month == DateTime.Today.Month && currentMonth.Year == DateTime.Today.Year ? Color.Red : Color.Black,
                            Font = new Font("標楷體", 10, FontStyle.Regular)
                        };
                        dayPanel.Controls.Add(lblDate);
                    }
                    else
                    {
                        dayPanel.BorderStyle = BorderStyle.FixedSingle;
                        dayPanel.BackColor = Color.LightGray;
                    }

                    this.Controls.Add(dayPanel);
                }
            }
        }
    }


}
