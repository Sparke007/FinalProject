using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class OrderItem
    {
        [Key]
        public int OrderItemId { get; set; }

        [Column(TypeName = "int")]
        public int OrderId { get; set; }

        [Column(TypeName = "int")]
        public int ProductId { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal O_Price { get; set; }
  
        [Column(TypeName = "int")]
        public int O_Qty { get; set; }
    }
}
