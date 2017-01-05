namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HR.EMPLOYEES")]
    public partial class Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee()
        {
            Departments = new HashSet<Department>();
            Subordinate = new HashSet<Employee>();
            JobsHistory = new HashSet<JobHistory>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("EMPLOYEE_ID")]
        public int EmployeeId { get; set; }

        [StringLength(20)]
        [Column("FIRST_NAME")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(25)]
        [Column("LAST_NAME")]
        public string LastNAme { get; set; }

        [Required]
        [StringLength(25)]
        [Column("EMAIL")]
        public string Email { get; set; }

        [StringLength(20)]
        [Column("PHONE_NUMBER")]
        public string PhoneNumber { get; set; }

        [Column("HIRE_DATE")]
        public DateTime HireDate { get; set; }

        [Required]
        [StringLength(10)]
        [Column("JOB_ID")]
        public string JobId { get; set; }

        [Column("SALARY")]
        public decimal? Salary { get; set; }

        [Column("COMMISSION_PCT")]
        public decimal? CommissionPct { get; set; }

        [Column("MANAGER_ID")]
        public int? ManagerId { get; set; }

        [Column("DEPARTMENT_ID")]
        public short? DepartmentId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Department> Departments { get; set; }

        public virtual Department Department { get; set; }

        public virtual Job Job { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employee> Subordinate { get; set; }

        public virtual Employee Boss { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JobHistory> JobsHistory { get; set; }
    }
}
