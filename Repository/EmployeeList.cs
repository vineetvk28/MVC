using System;
using System.Collections.Generic;
using Jitendra_Joshi_Assignment.Models;
using System.Linq;
using System.Web;

namespace Jitendra_Joshi_Assignment.Repository
{
    public static class EmployeeList
    {
        static List<Employee> emplist = null;

        static EmployeeList()
        {
            emplist = new List<Employee>()
            {
                new Employee
                {
                    EmployeeCode= 1,
                    FirstName = "Vineet",
                    LastName = "Kargeti",
                    YearsOfExperience = 5,
                    Email = "vineetkargeti@gmail.com",
                    PhoneNumber= 975906260
                }
            };
        }


        public static List<Employee> SelectEmployeeList()
        {
            return emplist;
        }

        public static void InsertEmployeeList(Employee emp)
        {
            emplist.Add(emp);
        }

        public static void UpdateEmployeeList(Employee emp)
        {
            Employee empUpdate = emplist.Find(x => x.EmployeeCode == emp.EmployeeCode);
            empUpdate.FirstName = emp.FirstName;
            empUpdate.LastName = emp.LastName;
            empUpdate.Email = emp.Email;
            empUpdate.PhoneNumber = emp.PhoneNumber;
            empUpdate.YearsOfExperience = emp.YearsOfExperience;
        }

        public static void DeleteEmployeeList(int id)
        {
            Employee empDelete = emplist.Find(x => x.EmployeeCode == id);
            emplist.Remove(empDelete);
        }
    }
}