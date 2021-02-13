using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test.Models;

namespace Test
{
    public partial class EmployeeForm : Form
    {
        public Employee Employee { get; set; }

        public EmployeeForm()
        {
            InitializeComponent();

            //todo dublicate
            SqlConnection sqlConnection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CrmContext;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("Select * FROM [dbo].[Positions]", sqlConnection);
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);

            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                comboBoxPosition.Items.Add(dataSet.Tables[0].Rows[i][1]);
            }
        }

        public EmployeeForm(Employee employee) : this()
        {
            Employee = employee ?? new Employee();
            secondName.Text = Employee.SecondName;
            firstName.Text = Employee.FirstName;
            Employee.PositionId = comboBoxPosition.SelectedIndex;
            numericSalary.Text = Employee.Salary.ToString();
            hired.Value = Employee.Hired;
            if (Employee.Fired != null)
            {
                fired.Value = (DateTime)Employee.Fired;
            }
        }

        private void AddEmployee_Click(object sender, EventArgs e)
        {
            //todo processing incoming data
            Employee = Employee ?? new Employee();
            Employee.SecondName = secondName.Text;
            Employee.FirstName = firstName.Text;
            Employee.PositionName = comboBoxPosition.SelectedItem.ToString();
            Employee.PositionId = comboBoxPosition.SelectedIndex + 1;
            Employee.Salary = Convert.ToDecimal(numericSalary.Text);
            Employee.Hired = hired.Value;

            if (fired.Value < DateTime.Now.AddMinutes(-1))
            {
                Employee.Fired = fired.Value;
            }
            else
            {
                Employee.Fired = null;
            }

            Close();
        }

        private void fired_ValueChanged(object sender, EventArgs e)
        {
            fired.CustomFormat = "dd/MM/yyyy";
        }

        private void fired_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
            {
                fired.CustomFormat = " ";
            }
        }
    }
}
