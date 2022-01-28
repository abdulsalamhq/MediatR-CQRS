using EmployeeManagementLibrary.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementLibrary.Queries
{
    public record GetEmployeeListQuery():IRequest<List<EmployeeModel>>;
    public record GetEmployeeByIdQuery(int Id) : IRequest<List<EmployeeModel>>;
}
