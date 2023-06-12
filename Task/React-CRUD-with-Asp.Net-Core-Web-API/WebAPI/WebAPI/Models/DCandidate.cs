using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class DCandidate
    {
        [Key]
        public int id { get; set; }

        [Column(TypeName ="nvarchar(100)")]
        public string type { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string barcode { get; set; }


        [Column(TypeName = "nvarchar(100)")]
        public string description { get; set; }
    }
}
