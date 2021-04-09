﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Jitendra_Joshi_Assignment.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {

        public List<Models.Employee> SelectAllEmployee()
        {
            return EmployeeList.SelectEmployeeList();
        }

        public Models.Employee SelectEmployeeById(int id)
        {
            return EmployeeList.SelectEmployeeList().Find(x => x.EmployeeCode == id);
        }
        public void UpdateEmployee(Models.Employee emp)
        {
            EmployeeList.UpdateEmployeeList(emp);
        }

        public void InsertEmployee(Models.Employee emp)
        {
            EmployeeList.InsertEmployeeList(emp);
        }
        public void DeleteEmployee(int id)
        {
            EmployeeList.DeleteEmployeeList(id);
        }

        public void UpdateEmployee(object emp)
        {
            throw new NotImplementedException();
        }
    }
}