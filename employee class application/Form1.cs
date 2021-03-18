using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * @version 3/13/2021
 * @author Christinaa Danks
 */

namespace EmployeeApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void employeeButton_Click(object sender, EventArgs e)
        {
            Employee employee1 = new Employee("Susan Meyers", 47899, "Accounting", "Vice President");

            Employee employee2 = new Employee("Mark Jones", 39119);
            employee2.employeeDept = "IT";
            employee2.employeePos = "Programmer";

            Employee employee3 = new Employee();
            employee3.employeeName = "Joy Rogers";
            employee3.employeeID = 81774;
            employee3.employeeDept = "Manufacturing";
            employee3.employeePos = "Engineer";

            // Create grid for display, title section
            dataGridView1.ColumnCount = 4;
            dataGridView1.RowCount = 3;
            dataGridView1.Columns[0].Name = "Name";
            dataGridView1.Columns[1].Name = "ID Number";
            dataGridView1.Columns[2].Name = "Department";
            dataGridView1.Columns[3].Name = "Position";

            // Fill in grid for each object
            dataGridView1.Rows[0].Cells[0].Value = employee1.employeeName;  // employee 1
            dataGridView1.Rows[0].Cells[1].Value = employee1.employeeID;
            dataGridView1.Rows[0].Cells[2].Value = employee1.employeeDept;
            dataGridView1.Rows[0].Cells[3].Value = employee1.employeePos;

            dataGridView1.Rows[1].Cells[0].Value = employee2.employeeName;  // employee 2
            dataGridView1.Rows[1].Cells[1].Value = employee2.employeeID;
            dataGridView1.Rows[1].Cells[2].Value = employee2.employeeDept;
            dataGridView1.Rows[1].Cells[3].Value = employee2.employeePos;

            dataGridView1.Rows[2].Cells[0].Value = employee3.employeeName;  // employee 3
            dataGridView1.Rows[2].Cells[1].Value = employee3.employeeID;
            dataGridView1.Rows[2].Cells[2].Value = employee3.employeeDept;
            dataGridView1.Rows[2].Cells[3].Value = employee3.employeePos;





        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
