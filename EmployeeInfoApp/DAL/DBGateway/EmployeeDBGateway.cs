using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeInfoApp.DAL.DAO;

namespace EmployeeInfoApp.DAL.DBGateway
{
    class EmployeeDBGateway
    {
        string connectionString = @"Data Source=.\sqlexpress; Database=EmployeeDB; Integrated Security=true";
        private SqlConnection aSqlConnection;
        private SqlCommand aSqlCommand;

        public EmployeeDBGateway()
        {
            aSqlConnection = new SqlConnection(connectionString);
        }
        public void Save(Employee anEmployee)
        {
            //int designationId = anEmployee.EmployeeDesignation.Id;
            string query = "INSERT INTO t_Employee VALUES('" +anEmployee.Name+ "', '" +anEmployee.Email+ "', '" +anEmployee.Address+ "', '" +anEmployee.DesignationId+ "')";
            aSqlConnection.Open();
            aSqlCommand = new SqlCommand(query, aSqlConnection);

            aSqlCommand.ExecuteNonQuery();
            aSqlConnection.Close();
        }

        public Employee FindEmail(string email)
        {
            string query = "SELECT * FROM t_Employee WHERE email = '" + email + "'";
            aSqlConnection.Open();
            aSqlCommand = new SqlCommand(query, aSqlConnection);

            SqlDataReader aSqlDataReader = aSqlCommand.ExecuteReader();

            Employee anEmployee;

            if (aSqlDataReader.HasRows)
            {
                anEmployee = new Employee();
                aSqlDataReader.Read();
                anEmployee.Name = aSqlDataReader["name"].ToString();
                anEmployee.Email = aSqlDataReader["email"].ToString();
                anEmployee.Address = aSqlDataReader["address"].ToString();
                anEmployee.DesignationId = (int)aSqlDataReader["designation_id"];
                aSqlDataReader.Close();
                aSqlConnection.Close();
                return anEmployee;
            }
            else
            {
                aSqlDataReader.Close();
                aSqlConnection.Close();
                return null;
            }
        }

        public List<Employee> SearchEmployee(string name)
        {
            List<Employee> employeeList = new List<Employee>();
            string query = "SELECT * FROM t_Employee";
            aSqlConnection.Open();
            
            Employee anEmployee;

            if (!String.IsNullOrEmpty(name))
            {
                query = "SELECT * FROM t_Employee WHERE name LIKE '%" + name + "%'";
            }

            aSqlCommand = new SqlCommand(query, aSqlConnection);

            SqlDataReader aSqlDataReader = aSqlCommand.ExecuteReader();

            while (aSqlDataReader.Read())
            {
                anEmployee = new Employee();
                anEmployee.Id = (int)aSqlDataReader["id"];
                anEmployee.Name = aSqlDataReader["name"].ToString();
                anEmployee.Email = aSqlDataReader["email"].ToString();
                anEmployee.Address = aSqlDataReader["address"].ToString();
                anEmployee.DesignationId = (int)aSqlDataReader["designation_id"];

                employeeList.Add(anEmployee);
            }

            return employeeList;
        }
    }
}
