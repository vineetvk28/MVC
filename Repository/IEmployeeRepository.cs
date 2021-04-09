using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jitendra_Joshi_Assignment.Repository
{
    interface IEmployeeRepository
    {
        List<Models.Employee> SelectAllEmployee();
        Models.Employee SelectEmployeeById(int id);
        void UpdateEmployee(Models.Employee emp);
        void InsertEmployee(Models.Employee emp);
        void DeleteEmployee(int id);
        void UpdateEmployee(object emp);
    }
}
