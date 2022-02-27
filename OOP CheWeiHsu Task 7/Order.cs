using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CheWeiHsu_Task_7
{
    class Order
    {
        public Order(int id, Guid orderNumber, int clientId)
        {
            Id = id;
            OrderNumber = orderNumber;
            ClientId = clientId;
        }

        public int Id { get; set; }
        public Guid OrderNumber { get; set; }//Guid 是可以產生特別代碼的指令，這些代碼在系統只會唯一存在，不會有重複代碼的情形
        public int ClientId { get; set; }
    }
}
