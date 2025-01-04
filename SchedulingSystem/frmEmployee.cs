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
    public partial class frmEmployee : Form
    {
        public EmployeeCollection employees { get; set; }
        public frmEmployee()
        {
            InitializeComponent();
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            if (employees != null)
            {
                employees.PopulateListView(lvEmployee);
            }
        }
    }
}
