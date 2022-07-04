using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class Customer
    {


        [Key]
        public int CustomerId { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string CustomerName { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string CustomerSurname { get; set; }

        [Column(TypeName = "varchar(15)")]
        public string CustomerNumber { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string CustomerEmail { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string CustomerPassword { get; set; }

     

    }
}
