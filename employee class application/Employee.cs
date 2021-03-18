using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * @version 3/13/2021
 * @author Christinaa Danks
 */

namespace EmployeeApplication
{
    class Employee
    {
        // Fields
        public string employeeName, employeeDept, employeePos;
        public int employeeID;

        // Constructors
        public Employee(string name, int id, string dept, string pos)
        {
            employeeName = name;
            employeeID = id;
            employeeDept = dept;
            employeePos = pos;
        }

        public Employee(string name, int id)
        {
            employeeName = name;
            employeeID = id;
            employeeDept = "";
            employeePos = "";
        }

        public Employee()
        {
            employeeName = "";
            employeeDept = "";
            employeePos = "";
            employeeID = 0;
        }
    }
}
