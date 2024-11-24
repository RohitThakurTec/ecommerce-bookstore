using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcomProject_1155.Models
{
    public class ShoppingCart
    {
        public ShoppingCart()
        {
            count = 1;
        }

        public int Id { get; set; } 
        public string ApplicationUserId {  get; set; }
        [ForeignKey("ApplicationUserId")]
        public  ApplicationUser ApplicationUser { get; set; }   
        public int  ProductId {  get; set; }
        [ForeignKey("ProductId")]
        public  Product Product { get; set; }   
        public int count {  get; set; } 
        [NotMapped]
        public double Price {  get; set; }  
    }
}
