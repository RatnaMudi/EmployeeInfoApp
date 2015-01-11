namespace EmployeeInfoApp.DAL.DAO
{
    class Employee
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Email { set; get; }
        public string Address { set; get; }
        //public Designation EmployeeDesignation { set; get; }
        public int DesignationId { set; get; }
    }
}
