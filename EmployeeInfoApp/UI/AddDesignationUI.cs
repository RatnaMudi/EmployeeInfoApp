using System;
using System.Windows.Forms;
using EmployeeInfoApp.BLL;
using EmployeeInfoApp.DAL.DAO;
using EmployeeInfoApp.DAL.DBGateway;

namespace EmployeeInfoApp.UI
{
    public partial class AddDesignationUI : Form
    {
        public AddDesignationUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Designation aDesignation = new Designation();
            aDesignation.Code = codeTextBox.Text;
            aDesignation.Title = titleTextBox.Text;

            DesignationManager aDesignationManager = new DesignationManager();
            string msg = aDesignationManager.Save(aDesignation);
            MessageBox.Show(msg);
        }
    }
}
