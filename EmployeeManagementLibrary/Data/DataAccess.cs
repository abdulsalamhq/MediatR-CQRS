using EmployeeManagementLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementLibrary.Data
{
    public class DataAccess : IDataAccess
    {
        public List<EmployeeModel> employees = new();
        public DataAccess()
        {
            employees.Add(new EmployeeModel { Id = 1, FirstName = "Abdul", LastName = "Salam" });
            employees.Add(new EmployeeModel { Id = 2, FirstName = "Mohammad", LastName = "Abdullah" });
        }

        public List<EmployeeModel> GetEmployees()
        {
            return employees;
        }
        public EmployeeModel AddEmployees(string firstName, string lastName)
        {
            EmployeeModel employeeModel = new()
            {
                FirstName = firstName,
                LastName = lastName

            };
            employeeModel.Id = employees.Max(x => x.Id) + 1;
            return employeeModel;
        }


    }
}
