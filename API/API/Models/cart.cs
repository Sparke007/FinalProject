using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class Cart
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "DateTimeOffset(7)")]
        public DateTimeOffset CreatedDate { get; set; }

        [Column(TypeName = "int")]
        public int CustomerId { get; set; }

        [Column(TypeName = "bit")]
        public bool IsDeleted { get; set; }

        
    }
}
