using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App1.Models;
using System.Data.Entity.Core.EntityClient;
using System.Data.Common;

namespace App1
{
    public partial class Form1 : Form
    {
        private HrContext db = new HrContext();
        private List<Employee> employes;

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            db.Database.Log = msg => Debug.WriteLine(msg);

            employes = db.Employees.ToList();
            dataGridView1.DataSource = employes;

            

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            db.SaveChanges();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //foreach (var entity in db.ChangeTracker.Entries())
            //{
            //    entity.Reload();
            //}

            //var myCurrencyManager =
            //         (CurrencyManager)dataGridView1.BindingContext[employes];
            //myCurrencyManager.Refresh();

            //facon la plus efficace, refaire un nouveau contexte.
            db = new HrContext();
            employes = db.Employees.ToList();
            dataGridView1.DataSource = employes;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            var inter1 = db.Employees;
            var inter2 = inter1.Where(emp => emp.Salary > 10000);
            var inter3 = inter2.OrderByDescending(emp => emp.Salary);
            employes = inter3.ToList();

            dataGridView1.DataSource = employes;

        }

        private void btnNombre_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{db.ChangeTracker.Entries().Count()}");
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
           dataGridView1.DataSource = db.Employees.Where(emp => emp.Salary < 10000).
                Select(emp => new { emp.Prenom, emp.LastName, emp.Salary }).ToList();

    
        }

        private void btnEmployeAvecDepartement_Click(object sender, EventArgs e)
        {
     

            //db.Configuration.LazyLoadingEnabled = false;
            var emps = db.Employees.Include(a=>a.Department).ToList();

            //foreach (Employee emp in emps)
            //{
            //    db.Entry(emp).Reference(a => a.Department).Load();
            //}

            
            var emps2= emps.Select(emp =>

              new EmployeWithDepartment
              {
                  EmployeeId = emp.EmployeeId,
                  FirstName = emp.Prenom,
                  LastName = emp.LastName,
                  Department = emp.Department?.DepartmentName
              }).ToList();

            dataGridView1.DataSource = emps2;

        }

        private void button1_Click(object sender, EventArgs e)
        {


            var results = db.Database.SqlQuery<EmployeWithDepartment>(
                "SELECT employee_Id AS EmployeeId, First_name AS FirstName, Last_Name AS LastName, Department_name AS Department " +
                " FROM HR.Employees INNER JOIN HR.Departments ON " +
                " HR.Employees.Department_ID=HR.Departments.Department_ID  " +
                "	WHERE Department_name=:name", "Shipping");


            var employes = results.ToList();
            dataGridView1.DataSource = employes;
        }
    }
}
