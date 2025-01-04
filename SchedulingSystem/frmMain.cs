namespace SchedulingSystem
{
    public partial class frmMain : Form
    {
        EmployeeCollection employees = new EmployeeCollection();

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
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

        private void tsmiQueryEmployee_Click(object sender, EventArgs e)
        {
            frmEmployee frmEmployee = new frmEmployee();
            frmEmployee.employees = employees;
            frmEmployee.ShowDialog(this);
        }
    }

}