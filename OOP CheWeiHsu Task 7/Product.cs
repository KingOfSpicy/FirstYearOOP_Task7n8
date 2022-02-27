using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CheWeiHsu_Task_7
{
    class Product
    {
        public Product(int id, string productName, decimal price)
        {
            Id = id;
            ProductName = productName;
            Price = price;
        }

        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
    }
}
