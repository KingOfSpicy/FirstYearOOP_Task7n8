using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CheWeiHsu_Task_7
{
    class Client
    {
        public Client(int id, string clientName, string city, Countries country)
        {
            Id = id;
            ClientName = clientName;//不可以是Name因為Product那裡也有Name需要輸入
            City = city;
            Country = country;
        }

        public int Id { get; set; }
        public string ClientName { get; set; }
        public string City { get; set; }
        public Countries Country { get; set; }
    }
    public enum Countries
    {
        Finland,
        Sweden,
        Norway,
        Iceland
    }
}
