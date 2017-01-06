namespace App1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HR.JOB_HISTORY")]
    public partial class JobHistory
    {
        [Key]
        [Column("EMPLOYEE_ID",Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EmployeeId { get; set; }

        [Key]
        [Column("START_DATE",Order = 1)]
        public DateTime StartDate { get; set; }

        [Column("END_DATE")]
        public DateTime EndDate { get; set; }

        [Required]
        [StringLength(10)]
        [Column("JOB_ID")]
        public string JobId { get; set; }

        [Column("DEPARTMENT_ID")]
        public short? DepartmentId { get; set; }

        public virtual Department Department { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual Job Job { get; set; }
    }
}
