namespace App1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HR.DEPARTMENTS")]
    public partial class Department
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Department()
        {
            Employees = new HashSet<Employee>();
            JobsHistory = new HashSet<JobHistory>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("DEPARTMENT_ID")]
        public short DepartmentId { get; set; }

        [Required]
        [StringLength(30)]
        [Column("DEPARTMENT_NAME")]
        public string DepartmentName { get; set; }

        [Column("MANAGER_ID")]
        public int? ManagerId { get; set; }

        [Column("LOCATION_ID")]
        public short? LocationId { get; set; }

        public virtual Location Location { get; set; }

        public virtual Employee Employee { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employee> Employees { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JobHistory> JobsHistory { get; set; }
    }
}
