namespace CalendarControlLibrary
{
    public partial class CalendarControl : UserControl
    {
        private DateTime currentMonth;

        // 定義日期點擊事件
        public event EventHandler<DateTime> DateClicked;

        // 定義一個字典來存儲日期和排班
        //public Dictionary<DateTime, Shift > shifts = new Dictionary<DateTime, Shift>();

        public CalendarControl()
        {
            InitializeComponent();
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

        public void LastMonth()
        {
            currentMonth = currentMonth.AddMonths(-1);
            GenerateCalendar();
        }

        public void NextMonth()
        {
            currentMonth = currentMonth.AddMonths(1);
            GenerateCalendar();
        }

        // 添加一個方法來設置排班
        //public void SetShift(DateTime date, Shift shift)
        //{
        //    shifts[date] = shift;
        //    GenerateCalendar();
        //}

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
                    Font = new Font("微軟正黑體", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 136),
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
                        Location = new Point(j * labelWidth, (i + 1) * labelHeight),
                        BackColor = Color.White,
                    };

                    int dayNumber = i * 7 + j - startDayOfWeek + 1;
                    Label lblDate = new Label
                    {
                        TextAlign = ContentAlignment.TopRight,
                        Dock = DockStyle.Top,
                        Font = new Font("Consolas", 10, FontStyle.Regular)
                    };

                    if (dayNumber > 0 && dayNumber <= daysInMonth)
                    {
                        lblDate.Text = $"{currentMonth.Month}/{dayNumber}";
                        if (dayNumber == DateTime.Today.Day && currentMonth.Month == DateTime.Today.Month && currentMonth.Year == DateTime.Today.Year)
                        {
                            dayPanel.BackColor = Color.LightBlue;
                        }
                        else
                        {
                            lblDate.ForeColor = Color.Black;
                        }

                        // 檢查是否有排班
                        //DateTime currentDate = new DateTime(currentMonth.Year, currentMonth.Month, dayNumber);
                        //if (shifts.ContainsKey(currentDate))
                        //{
                        //    Label lblShift = new Label
                        //    {
                        //        Text = $"{shifts[currentDate].Description} ({shifts[currentDate].User})",
                        //        TextAlign = ContentAlignment.BottomLeft,
                        //        Dock = DockStyle.Bottom,
                        //        Font = new Font("Consolas", 8, FontStyle.Italic),
                        //        ForeColor = Color.Green
                        //    };
                        //    dayPanel.Controls.Add(lblShift);
                        //}
                    }
                    else
                    {
                        DateTime otherMonthDate = firstDayOfMonth.AddDays(dayNumber - 1);
                        lblDate.Text = $"{otherMonthDate.Month}/{otherMonthDate.Day}";
                        lblDate.ForeColor = Color.DarkGray;
                        dayPanel.BackColor = Color.LightGray;
                    }

                    dayPanel.Controls.Add(lblDate);
                    dayPanel.BorderStyle = BorderStyle.FixedSingle;
                    dayPanel.MouseEnter += (s, e) => dayPanel.BackColor = Color.LightPink;
                    dayPanel.MouseLeave += (s, e) =>
                    {
                        if (dayNumber == DateTime.Today.Day && currentMonth.Month == DateTime.Today.Month && currentMonth.Year == DateTime.Today.Year)
                        {
                            dayPanel.BackColor = Color.LightBlue;
                        }
                        else if (dayNumber > 0 && dayNumber <= daysInMonth)
                        {
                            dayPanel.BackColor = Color.White;
                        }
                        else
                        {
                            dayPanel.BackColor = Color.LightGray;
                        }
                    };

                    // 添加點擊事件處理程序
                    dayPanel.Click += (s, e) =>
                    {
                        DateTime clickedDate;
                        if (dayNumber > 0 && dayNumber <= daysInMonth)
                        {
                            clickedDate = new DateTime(currentMonth.Year, currentMonth.Month, dayNumber);
                        }
                        else
                        {
                            clickedDate = firstDayOfMonth.AddDays(dayNumber - 1);
                        }
                        DateClicked?.Invoke(this, clickedDate);
                    };

                    this.Controls.Add(dayPanel);
                }
            }
        }
    }

}
