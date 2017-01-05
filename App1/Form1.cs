using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebApplication1.Models;

namespace App1
{
    public partial class Form1 : Form
    {
        private HrContext db = new HrContext(); 

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            List<Employee> employes = db.Employees.ToList();
            dataGridView1.DataSource = employes;

        }
    }
}
