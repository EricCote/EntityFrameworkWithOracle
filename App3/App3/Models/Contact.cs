using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App3.Models
{
    public class Contact
    {
        public int ContactID { get; set; }

        [StringLength(50)]
        public string Nom { get; set; }

        public string Courriel { get; set; }


    }
}