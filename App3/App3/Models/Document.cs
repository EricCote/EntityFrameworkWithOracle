using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace App3.Models
{
    public class Document
    {
        public int DocumentId { get; set; }
        //[Column(TypeName = "blob")]
        public byte[] Attachment { get; set; }
        public string MimeType { get; set; }
        public int numberOfDownloads { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}