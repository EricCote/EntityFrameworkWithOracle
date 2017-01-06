using App3.Migrations;
using App3.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        InfolettreContext db = new InfolettreContext();


        private void Form1_Load(object sender, EventArgs e)
        {
            //Database.SetInitializer(new
            //    DropCreateDatabaseIfModelChanges<InfolettreContext>());

            //Database.SetInitializer<InfolettreContext>(null);

            var contact = new Contact()
            {
                Nom = "Duc",
                Courriel = "aa@aa.com"
            };

            db.Contacts.Add(contact);
            db.SaveChanges();
        }
    }
}
