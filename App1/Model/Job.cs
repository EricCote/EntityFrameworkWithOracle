namespace App1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HR.JOBS")]

    public partial class Job
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Job()
        {
            Employees = new HashSet<Employee>();
            JobsHistory = new HashSet<JobHistory>();
        }

        [Key]
        [StringLength(10)]
        [Column("JOB_ID")]
        public string JobId { get; set; }

        [Required]
        [StringLength(35)]
        [Column("JOB_TITLE")]
        public string JobTitle { get; set; }

        [Column("MIN_SALARY")]
        public int? MinSalary { get; set; }

        [Column("MAX_SALARY")]
        public int? MaxSalary { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employee> Employees { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JobHistory> JobsHistory { get; set; }
    }
}
