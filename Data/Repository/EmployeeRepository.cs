using Data.Context;
using Data.Interface;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmpContext _context;
        public EmployeeRepository(EmpContext context)
        {
            _context = context;
        }

        public Employee Get()
        {
            return _context.Employees.FirstOrDefault();
        }
    }
}
