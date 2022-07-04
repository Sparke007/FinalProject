using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class Category
    {  
        [Key]
        public int Cat_ID { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string CategoryName { get; set; }
    }
}
