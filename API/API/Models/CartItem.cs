using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class CartItem
    {
        [Key]
        public int CartItemId { get; set; }


        [Column(TypeName = "int")]
        public long Cart_Id { get; set; }


        [Column(TypeName = "int")]            
        public int ProductId { get; set; }


        [Column(TypeName = "int")]
        public decimal TotalAmount { get; set; }


        [Column(TypeName = "int")]
        public int Quantity { get; set; }



         }
    }

