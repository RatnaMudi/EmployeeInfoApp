using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeInfoApp.DAL.DAO;

namespace EmployeeInfoApp.DAL.DBGateway
{
    class DesignationDBGateway
    {
        string connectionString = @"Data Source=.\sqlexpress; Database=EmployeeDB; Integrated Security=true";
        private SqlConnection aSqlConnection;
        private SqlCommand aSqlCommand;

        public DesignationDBGateway()
        {
            aSqlConnection = new SqlConnection(connectionString);
        }
        public void Save(Designation aDesignation)
        {
            string query = "INSERT INTO t_Designation VALUES('" + aDesignation.Code + "', '" + aDesignation.Title + "')";
            aSqlConnection.Open();
            aSqlCommand = new SqlCommand(query, aSqlConnection);
            
            aSqlCommand.ExecuteNonQuery();
            aSqlConnection.Close();
        }

        public Designation Find(string code)
        {
            string query = "SELECT * FROM t_Designation WHERE code = '" +code+ "'";
            aSqlConnection.Open();
            aSqlCommand = new SqlCommand(query, aSqlConnection);

            SqlDataReader aSqlDataReader = aSqlCommand.ExecuteReader();

            Designation aDesignation;

            if (aSqlDataReader.HasRows)
            {
                aDesignation = new Designation();
                aSqlDataReader.Read();
                aDesignation.Id = Convert.ToInt32(aSqlDataReader["id"]);
                aDesignation.Code = aSqlDataReader["code"].ToString();
                aDesignation.Title = aSqlDataReader["title"].ToString();
                aSqlDataReader.Close();
                aSqlConnection.Close();
                return aDesignation;
            }
            else
            {
                aSqlDataReader.Close();
                aSqlConnection.Close();
                return null;
            }
        }

        public List<Designation> LoadDesignationList()
        {
            List<Designation> designationList = new List<Designation>();
            string query = "SELECT * FROM t_Designation";
            aSqlCommand = new SqlCommand(query, aSqlConnection);
            aSqlConnection.Open();
            SqlDataReader aSqlDataReader = aSqlCommand.ExecuteReader();

            while (aSqlDataReader.Read())
            {
                Designation designation = new Designation();
                designation.Id = (int)aSqlDataReader["id"];
                designation.Code = aSqlDataReader["code"].ToString();
                designation.Title = aSqlDataReader["title"].ToString();
                designationList.Add(designation);
            }
            aSqlDataReader.Close();
            aSqlConnection.Close();

            return designationList;
        }
    }
}
