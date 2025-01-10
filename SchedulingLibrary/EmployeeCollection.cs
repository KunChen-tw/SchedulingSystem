using System.Collections.ObjectModel;



public class EmployeeCollection : Collection<Employee>
    {
        public bool ValidateEmployeeAccount(string account)
        {
            // 檢查ID是否為空或null
            if (string.IsNullOrEmpty(account))
            {
                return false;
            }

            // 檢查ID是否已存在於集合中
            foreach (var employee in this)
            {
                if (employee.Account.Equals(account))
                {
                    return true; // 帳號存在
                }
            }

            return false; // 找無帳號
        }
        
        public Employee Login(string account, string password)
        {
            foreach (var employee in this)
            {
                if (employee.Account.Equals(account) && employee.Password.Equals(password))
                {
                    return employee; // 登入成功，返回員工對象
                }
            }
            return null; // 登入失敗，返回null
        }


        public void PopulateListView(ListView listView)
        {
            listView.Items.Clear(); // 清空現有項目

            foreach (var employee in this)
            {
                ListViewItem item = new ListViewItem(employee.Name);
                item.SubItems.Add(employee.Account);
                item.SubItems.Add(employee.Level.ToString());
                listView.Items.Add(item); // 將員工項目添加到ListView
            }
        }
    }

