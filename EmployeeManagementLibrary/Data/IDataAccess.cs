using EmployeeManagementLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementLibrary.Data
{
    public interface IDataAccess
    {
        List<EmployeeModel> GetEmployees();

        EmployeeModel AddEmployees(string FirstName,string LastName);
    }
}
