namespace SchedulingSystem
{
    public partial class frmMain : Form
    {
        EmployeeCollection employees = new EmployeeCollection();
        //private Panel pnlCalendar;
        private CalendarControl calendarControl;

        public frmMain()
        {
            InitializeComponent();
            InitializeCalendarPanel();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadEmployeeData();

            frmLogin frmLogin = new frmLogin();
            frmLogin.employees = employees;
            if (frmLogin.ShowDialog(this) == DialogResult.OK)
            {
                if (frmLogin.employee.Level == 1)
                {
                    this.tsmiEmployee.Visible = true;
                }
            }
            else
            {
                this.Close();
            }
        }

        private void LoadEmployeeData()
        {
            // 讀取員工資料
            string[] lines = System.IO.File.ReadAllLines("Employee.csv");
            foreach (var line in lines)
            {
                try
                {
                    Employee employee = new Employee(line);
                    employees.Add(employee);
                }
                catch (ArgumentException ex)
                {
                    // 處理CSV格式不正確的情況
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void tsmiQueryEmployee_Click(object sender, EventArgs e)
        {
            frmEmployee frmEmployee = new frmEmployee();
            frmEmployee.employees = employees;
            frmEmployee.ShowDialog(this);
        }

        private void InitializeCalendarPanel()
        {
            //pnlCalendar = new Panel
            //{
            //    Location = new Point(10, 50),
            //    Size = new Size(this.ClientSize.Width - 20, this.ClientSize.Height - 60),
            //    Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right
            //};
            //this.Controls.Add(pnlCalendar);

            calendarControl = new CalendarControl
            {
                Dock = DockStyle.Fill
            };
            pnlCalendar.Controls.Add(calendarControl);
        }
    }

}