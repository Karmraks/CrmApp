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
    public partial class CrmUi : Form
    {
        CrmContext db;

        private SqlConnection sqlConnection= null;

        private SqlDataAdapter sqlDA= null;

        private DataSet dataSet = null;

        public CrmUi()
        {
            InitializeComponent();
            db = new CrmContext();
        }

        private void AddEmployee_Click(object sender, EventArgs e)
        {
            EmployeeForm employeeForm = new EmployeeForm();
            if (employeeForm.ShowDialog() == DialogResult.OK)
            {
                db.Employees.Add(employeeForm.Employee);
                db.SaveChanges();
            }
            ReloadData();
        }

        private void AddPosition_Click(object sender, EventArgs e)
        {
            PositionForm positionForm = new PositionForm();
            if (positionForm.ShowDialog() == DialogResult.OK)
            {
                db.Positions.Add(positionForm.Position);
                db.SaveChanges();
            }
        }

        private void LoadData()
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand(
                    "Select [FirstName], [SecondName], [PositionName], [Salary], [Hired], [Fired] " +
                    "FROM [dbo].[Employees]", sqlConnection);

                sqlDA = new SqlDataAdapter(sqlCommand);

                dataSet = new DataSet();

                sqlDA.Fill(dataSet, "Employees");

                dataGridView.DataSource = dataSet.Tables["Employees"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReloadData()
        {
            try
            {
                dataSet.Tables["Employees"].Clear();

                sqlDA.Fill(dataSet, "Employees");

                dataGridView.DataSource = dataSet.Tables["Employees"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CrmUi_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CrmContext;Integrated Security=True");

            sqlConnection.Open();

            LoadData();
        }

        private void reloadBtn_Click(object sender, EventArgs e)
        {
            ReloadData();
        }
    }
}
