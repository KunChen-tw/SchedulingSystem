

using CalendarControlLibrary;

namespace SchedulingSystem
{
    public partial class frmMain : Form
    {
        EmployeeCollection employees = new EmployeeCollection();
        private Employee currentEmployee; // 新增的私有變數

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadEmployeeData();

            frmLogin frmLogin = new frmLogin();
            frmLogin.employees = employees;
            if (frmLogin.ShowDialog(this) == DialogResult.OK)
            {
                currentEmployee = frmLogin.employee; // 設定現在登入的員工
                if (currentEmployee.Level == 1)
                {
                    this.tsmiEmployee.Visible = true;
                    this.lblEmployeeJobGTitle.Text = "店長";
                }
                else
                {
                    this.tsmiEmployee.Visible = false;
                    this.lblEmployeeJobGTitle.Text = "員工";
                }

                // 顯示登入員工的姓名
                lblEmployeeName.Text = currentEmployee.Name;

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

        private void calMain_DateClicked(object sender, DateTime e)
        {
            // 處理日期點擊事件
            //MessageBox.Show($"您點擊了日期: {e.ToShortDateString()}");
            frmDayShift frmDayShift = new frmDayShift();
            frmDayShift.selectTime = e;
            frmDayShift.ShowDialog(this);
        }

        private void btnNextMonth_Click(object sender, EventArgs e)
        {
            this.calMain.NextMonth();
        }

        private void btnLastMonth_Click(object sender, EventArgs e)
        {
            this.calMain.LastMonth();
        }
    }

}