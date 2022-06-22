using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderItemWebApi.Models
{
    public class Cart
    {
        public int Id { get; set; }
      //  public int MenuItemId { get; set; }
        public int UserId { get; set; }
      // public int Quantity { get; set; }
        public int price { get; set; }


        public string Name { get; set; }
    }
}
