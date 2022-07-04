using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class Orders
    {
        [Key]
        public int OrderId { get; set; }

        [Column(TypeName = "datetimeoffset(7)")]
        public DateTimeOffset OrderDate { get; set; } = DateTimeOffset.Now;

        [Column(TypeName = "varchar(50)")]
        public string OrdersNumber { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal OrdersAmount { get; set; }

        [Column(TypeName = "int")]
        public int OrdersStatus { get; set; }

        [Column(TypeName = "int")]
        public int Cart_Id { get; set; }         
      
        [Column(TypeName = "int")]
        public int Customer_o_Id { get; set; }

    }
}
