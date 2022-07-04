using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class Products
    {
        [Key]
        public int ProductID { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string ProductName { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal ProductPrice { get; set; }

        [Column(TypeName = "varchar(1000)")]
        public string ProductDiscription { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal ProductQuantity { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string ProductImage { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string ProductImage1 { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string ProductImage2 { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string ProductImage3 { get; set; }

        [Column(TypeName = "int")]
        public int Cat_Id { get; set; }

    }
}
