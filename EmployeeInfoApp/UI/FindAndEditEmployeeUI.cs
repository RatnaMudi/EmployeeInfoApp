using System.Collections.Generic;
using System.Windows.Forms;
using EmployeeInfoApp.BLL;
using EmployeeInfoApp.DAL.DAO;

namespace EmployeeInfoApp.UI
{
    public partial class FindAndEditEmployeeUI : Form
    {
        public FindAndEditEmployeeUI()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, System.EventArgs e)
        {
            resultListView.Items.Clear();
            EmployeeManager anEmployeeManager = new EmployeeManager();
            List<Employee> employeeList = anEmployeeManager.SearchEmployee(searchNameTextBox.Text);

            foreach (Employee employee in employeeList)
            {
                ListViewItem aListViewItem = new ListViewItem();

                aListViewItem.Text = employee.Id.ToString();
                aListViewItem.SubItems.Add(employee.Name);
                aListViewItem.SubItems.Add(employee.Email);

                aListViewItem.Tag = employee;

                resultListView.Items.Add(aListViewItem);
            }
        }

    }
}
