using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App3.Models
{
    public class InfolettreContext:DbContext
    {
        public InfolettreContext() : base("name=hr")
        {
            
        }

        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Document> Documents { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("HR");
            base.OnModelCreating(modelBuilder);
        }
    }
}
