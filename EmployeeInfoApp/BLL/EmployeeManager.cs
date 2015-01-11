using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeInfoApp.DAL.DAO;
using EmployeeInfoApp.DAL.DBGateway;

namespace EmployeeInfoApp.BLL
{
    class EmployeeManager
    {
        EmployeeDBGateway anEmployeeDbGateway = new EmployeeDBGateway();
        public string Save(Employee anEmployee)
        {
            

            Employee employee = anEmployeeDbGateway.FindEmail(anEmployee.Email);
            if (employee == null)
            {
                anEmployeeDbGateway.Save(anEmployee);
                return "Employee added successfully.";
            }
            else
            {
                return "Duplicate email. Try with different one.";
            }
        }

        public List<Designation> LoadDesignationList()
        {
            DesignationDBGateway aDesignationDbGateway = new DesignationDBGateway();
            return aDesignationDbGateway.LoadDesignationList();
        }

        public List<Employee> SearchEmployee(string name)
        {
            return anEmployeeDbGateway.SearchEmployee(name);
        }
    }
}
