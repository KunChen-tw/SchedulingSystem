namespace SchedulingSystem
{
    public partial class frmLogin : Form
    {
        public EmployeeCollection employees { get; set; }
        public Employee employee { get; set; }

        private int loginCount = 1;
        public frmLogin()
        {
            InitializeComponent();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (loginCount >= 3)
            {
                this.Close();
            }
            loginCount++;

            string strAccount = txtAccount.Text;
            string strPassword = txtPassword.Text;

            bool hasEmployee = employees.ValidateEmployeeAccount(strAccount);

            if (!hasEmployee)
            {
                MessageBox.Show($"查無此帳號", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Employee employee = employees.Login(strAccount, strPassword);
                if (employee == null)
                {
                    MessageBox.Show($"登入失敗", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string employeeType = employee.Level == 1 ? "店長" : "員工";
                    MessageBox.Show($"歡迎 {employeeType} {employee.Name} 登入", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DialogResult = DialogResult.OK;
                    this.employee = employee;
                }
            }
        }
    }
}
    