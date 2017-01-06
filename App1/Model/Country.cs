namespace App1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HR.COUNTRIES")]
    public partial class Country
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Country()
        {
            Locations = new HashSet<Location>();
        }

        [Key]
        [StringLength(2)]
        [Column("COUNTRY_ID")]
        public string CountryId { get; set; }

        [StringLength(40)]
        [Column("COUNTRY_NAME")]
        public string CountryName { get; set; }

        [Column("REGION_ID")]
        public decimal? RegionId { get; set; }

        public virtual Region Region { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Location> Locations { get; set; }
    }
}
