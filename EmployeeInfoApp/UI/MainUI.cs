using System;
using System.Windows.Forms;

namespace EmployeeInfoApp.UI
{
    public partial class MainUI : Form
    {
        public MainUI()
        {
            InitializeComponent();
        }

        private void addEmployeeButton_Click(object sender, EventArgs e)
        {
            EmployeeInfoUI anEmployeeInfoUi = new EmployeeInfoUI();
            anEmployeeInfoUi.ShowDialog();
        }

        private void addDesignationButton_Click(object sender, EventArgs e)
        {
            AddDesignationUI anAddDesignationUi = new AddDesignationUI();
            anAddDesignationUi.ShowDialog();
        }

        private void findAndEditButton_Click(object sender, EventArgs e)
        {
            FindAndEditEmployeeUI afiFindAndEditEmployeeUi = new FindAndEditEmployeeUI();
            afiFindAndEditEmployeeUi.ShowDialog();
        }
    }
}
