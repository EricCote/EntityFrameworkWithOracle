namespace App1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HR.LOCATIONS")]
    public partial class Location
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Location()
        {
            Departments = new HashSet<Department>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("LOCATION_ID")]
        public short LocationId { get; set; }

        [StringLength(40)]
        [Column("STREET_ADDRESS")]
        public string StreetAddress { get; set; }

        [StringLength(12)]
        [Column("POSTAL_CODE")]
        public string PostalCode { get; set; }

        [Required]
        [StringLength(30)]
        [Column("CITY")]
        public string City { get; set; }

        [StringLength(25)]
        [Column("STATE_PROVINCE")]
        public string StateProvince { get; set; }

        [StringLength(2)]
        [Column("COUNTRY_ID")]
        public string CountryId { get; set; }

        public virtual Country Country { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Department> Departments { get; set; }
    }
}
