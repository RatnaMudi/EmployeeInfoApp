using EmployeeInfoApp.DAL.DAO;
using EmployeeInfoApp.DAL.DBGateway;

namespace EmployeeInfoApp.BLL
{
    class DesignationManager
    {
        private const int MIN_LENGTH_OF_CODE = 3;
        public string Save(Designation aDesignation)
        {
            DesignationDBGateway aDesignationDbGateway = new DesignationDBGateway();

            if (aDesignation.Code.Length < MIN_LENGTH_OF_CODE)
            {
                return "Code length must be more than " +MIN_LENGTH_OF_CODE+ " characters.";
            }
            else
            {

                Designation designation = aDesignationDbGateway.Find(aDesignation.Code);
                if (designation == null)
                {
                    aDesignationDbGateway.Save(aDesignation);
                    return "Designation added";
                }
                else
                {
                    return "Duplicate code. Try with different one.";
                }
            }

        }
    }
}
