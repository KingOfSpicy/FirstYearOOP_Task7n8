using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CheWeiHsu_Task_7
{
    class OrderProduct
    {
        public OrderProduct(int id, int quantity, bool shipped, DateTime dateOfShipping, int orderId, int productId)
        {
            Id = id;
            Quantity = quantity;
            Shipped = shipped;
            DateOfShipping = dateOfShipping;
            OrderId = orderId;
            ProductId = productId;
        }

        public int Id { get; set; }
        public int Quantity { get; set; }
        public bool Shipped { get; set; }
        public DateTime DateOfShipping { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
    }
}
