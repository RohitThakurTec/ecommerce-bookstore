﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcomProject_1155.Models
{
    public class OrderDetails
    {
        public int Id { get; set; } 
        public   int OrderHeaderId {  get; set; }
        [ForeignKey("OrderHeaderId")]
        public OrderHeader OrderHeader { get; set; }    
        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }    
        public int count { get; set; }  
        public double price { get; set; }   
    }
}
