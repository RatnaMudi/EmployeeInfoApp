using System;
using System.Windows.Forms;
using EmployeeInfoApp.BLL;
using EmployeeInfoApp.DAL.DAO;

namespace EmployeeInfoApp.UI
{
    public partial class EmployeeInfoUI : Form
    {
        public EmployeeInfoUI()
        {
            InitializeComponent();
        }
        private void EmployeeInfoUI_Load(object sender, EventArgs e)
        {
            EmployeeManager anEmployeeManager = new EmployeeManager();
            designationComboBox.DisplayMember = "Title";
            designationComboBox.ValueMember = "Id";
            designationComboBox.DataSource = null;
            designationComboBox.DataSource = anEmployeeManager.LoadDesignationList();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Employee anEmployee = new Employee();
            anEmployee.Name = nameTextBox.Text;
            anEmployee.Email = emailTextBox.Text;
            anEmployee.Address = addressTextBox.Text;
            anEmployee.DesignationId = (int)designationComboBox.SelectedValue;

            EmployeeManager anEmployeeManager = new EmployeeManager();
            string msg = anEmployeeManager.Save(anEmployee);
            MessageBox.Show(msg);
        }
    }
}
