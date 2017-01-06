using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App1.Models
{
    public class Contact
    {

        [Required]
        [StringLength(25)]
        [Column("EMAIL")]
        public string Email { get; set; }

        [StringLength(20)]
        [Column("PHONE_NUMBER")]
        public string PhoneNumber { get; set; }
    }
}