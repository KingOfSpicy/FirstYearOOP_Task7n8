using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CheWeiHsu_Task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Now;
            List<Client> clients = new List<Client>()
            {
                new Client(1, "Donald Duck", "Porvoo", Countries.Finland),
                new Client(2, "Bigtime Beagle", "Stockholm", Countries.Sweden),
                new Client(3, "Droofus Drake", "Oslo", Countries.Norway),
                new Client(4, "Elmer Elephant", "Espoo", Countries.Finland),
                new Client(5, "Mickey Mouse", "Helsinki", Countries.Finland),
                new Client(6, "Ludwig von Drake", "Gothenburg", Countries.Sweden),
                new Client(7, "Gyro Gearloose", "Bergen", Countries.Norway),
                new Client(8, "Scrooge McDuck", "Reykjavik", Countries.Iceland),
                new Client(9, "Minnie Mouse", "Mikkeli", Countries.Finland),
                new Client(10, "Big Bad Wolf", "Sandviken", Countries.Sweden),
                new Client(11, "Mortimer Mouse", "Lillehammer", Countries.Norway),
                new Client(12, "Lil Bad Wolf", "Trondheim", Countries.Norway),
                new Client(13, "Gosalyn Loosey", "Kotka", Countries.Finland),
                new Client(14, "Gus Goose", "Stavanger", Countries.Norway),
                new Client(15, "Honker Muddlefoot", "Ronneby", Countries.Sweden),
                new Client(16, "Horace Horsecollar", "Keflavik", Countries.Iceland),
                new Client(17, "Gladstone Gander", "Dalvik", Countries.Iceland),
                new Client(18, "Flintheart Glomgold", "Kouvola", Countries.Finland),
                new Client(19, "Fiddler Pig", "Sigtuna", Countries.Sweden),
                new Client(20, "Newton Gearloose", "Sandnes", Countries.Norway),
                new Client(21, "Bouncer Beagle", "Mariestad", Countries.Sweden),
                new Client(22, "Clara Cluck", "Drammen", Countries.Norway)
            };
            List<Product> products = new List<Product>()
            {
                new Product(1, "Cooking Chef", 123.55m),
                new Product(2, "Hand Blender", 55.65m),
                new Product(3, "Citrus Press", 12.95m),
                new Product(4, "Glass Kettle", 32.20m),
                new Product(5, "Garlic Press", 18.35m),
                new Product(6, "Pepper Mill", 22.85m),
                new Product(7, "Thermocouple Thermometer", 116.20m),
                new Product(8, "Oven Glove", 43.45m),
                new Product(9, "Barbecue grill", 165.30m),
                new Product(10, "Blazier", 39.25m),
                new Product(11, "Cheesemelter", 26.95m),
                new Product(12, "Corn roaster", 77.85m),
                new Product(13, "Espresso machine", 279.75m),
                new Product(14, "Pancake machine", 55.65m),
                new Product(15, "Waffle iron", 48.45m),
                new Product(16, "Panini sandwich grill", 111.55m),
                new Product(17, "Swivel Peeler", 29.50m)
            };
            List<Order> orders = new List<Order>()
            {
                new Order(1, Guid.NewGuid(), 1),
                new Order(2, Guid.NewGuid(), 2),
                new Order(3, Guid.NewGuid(), 3),
                new Order(4, Guid.NewGuid(), 4),
                new Order(5, Guid.NewGuid(), 5),
                new Order(6, Guid.NewGuid(), 6),
                new Order(7, Guid.NewGuid(), 7),
                new Order(8, Guid.NewGuid(), 8),
                new Order(9, Guid.NewGuid(), 9),
                new Order(10, Guid.NewGuid(), 10),
                new Order(11, Guid.NewGuid(), 11),
                new Order(12, Guid.NewGuid(), 12),
                new Order(13, Guid.NewGuid(), 13),
                new Order(14, Guid.NewGuid(), 14),
                new Order(15, Guid.NewGuid(), 15),
                new Order(16, Guid.NewGuid(), 16),
                new Order(17, Guid.NewGuid(), 17),
                new Order(18, Guid.NewGuid(), 18),
                new Order(19, Guid.NewGuid(), 19),
                new Order(20, Guid.NewGuid(), 20),
                new Order(21, Guid.NewGuid(), 21),
                new Order(22, Guid.NewGuid(), 22)

            };
            List<OrderProduct> orderProducts = new List<OrderProduct>()
            {
                //Donald Duck
                new OrderProduct(1, 3, true, today.AddMonths(-2).AddDays(1), 1, 1),
                new OrderProduct(2, 3, true, today.AddMonths(-2).AddDays(1), 1, 8),
                //Bigtime Beagle
                new OrderProduct(3, 2, false, today.AddMonths(1).AddDays(1), 2, 2),
                new OrderProduct(4, 2, false, today.AddMonths(1).AddDays(1), 2, 9),
                new OrderProduct(5, 2, true, today.AddMonths(-1).AddDays(1), 2, 11),
                //Droofus Drake
                new OrderProduct(6, 4, true, today.AddMonths(-2).AddDays(1), 3, 3),
                new OrderProduct(7, 4, true, today.AddMonths(-2).AddDays(1), 3, 10),
                new OrderProduct(8, 4, false, today.AddMonths(1).AddDays(2), 3, 12),
                //Elmer Elephant
                new OrderProduct(9, 1, false, today.AddMonths(1).AddDays(3), 4, 4),
                new OrderProduct(10, 1, false, today.AddMonths(1).AddDays(3), 4, 11),
                //Mickey Mouse
                new OrderProduct(11, 1, true, today.AddMonths(-2).AddDays(4), 5, 5),
                new OrderProduct(12, 1, true, today.AddMonths(-2).AddDays(4), 5, 12),
                //Ludvig von Drake
                new OrderProduct(13, 4, true, today.AddMonths(-2).AddDays(5), 6, 6),
                new OrderProduct(14, 4, true, today.AddMonths(-2).AddDays(5), 6, 13),
                //Gyro Gearloose
                new OrderProduct(15, 5, false, today.AddMonths(1).AddDays(4), 7, 7),
                new OrderProduct(16, 5, false, today.AddMonths(1).AddDays(4), 7, 14),
                //Scrooge McDuck
                new OrderProduct(17, 2, true, today.AddMonths(-2).AddDays(6), 8, 8),
                new OrderProduct(18, 2, true, today.AddMonths(-2).AddDays(6), 8, 15),
                //Minnie Mouse
                new OrderProduct(19, 2, true, today.AddMonths(-2).AddDays(6), 9, 7),
                new OrderProduct(20, 2, true, today.AddMonths(-2).AddDays(6), 9, 16),
                //Big Bad Wolf
                new OrderProduct(21, 1, true, today.AddMonths(-2).AddDays(7), 10, 6),
                new OrderProduct(22, 1, true, today.AddMonths(-2).AddDays(7), 10, 17),
                //Mortimer Mouse
                new OrderProduct(23, 3, false, today.AddMonths(1).AddDays(5), 11, 5),
                new OrderProduct(24, 3, false, today.AddMonths(1).AddDays(5), 11, 15),
                //Lil Bad Wolf
                new OrderProduct(25, 1, true, today.AddMonths(-2).AddDays(7), 12, 4),
                new OrderProduct(26, 1, true, today.AddMonths(-2).AddDays(7), 12, 14),
                //Gosalyn Loosey
                new OrderProduct(27, 5, false, today.AddMonths(1).AddDays(6), 13, 3),
                new OrderProduct(28, 5, false, today.AddMonths(1).AddDays(6), 13, 13),
                //Gus Goose
                new OrderProduct(29, 4, true, today.AddMonths(-2).AddDays(8), 14, 2),
                new OrderProduct(30, 4, true, today.AddMonths(-2).AddDays(8), 14, 12),
                //Honker Muddlefoot
                new OrderProduct(31, 3, true, today.AddMonths(-2).AddDays(7), 15, 1),
                new OrderProduct(32, 3, true, today.AddMonths(-2).AddDays(7), 15, 11),
                new OrderProduct(33, 3, true, today.AddMonths(-2).AddDays(7), 15, 17),
                //Horace Horcecollar
                new OrderProduct(34, 2, true, today.AddMonths(-2).AddDays(6), 16, 2),
                new OrderProduct(35, 2, true, today.AddMonths(-2).AddDays(6), 16, 10),
                //Gladstone Gander
                new OrderProduct(36, 3, true, today.AddMonths(-2).AddDays(5), 17, 3),
                new OrderProduct(37, 3, true, today.AddMonths(-2).AddDays(5), 17, 9),
                //Flintheart Glomgold
                new OrderProduct(38, 3, true, today.AddMonths(-2).AddDays(4), 18, 4),
                new OrderProduct(39, 5, false, today.AddMonths(1).AddDays(5), 18, 8),
                new OrderProduct(40, 5, false, today.AddMonths(1).AddDays(5), 18, 6),
                //Fiddler Pig
                new OrderProduct(41, 2, false, today.AddMonths(1).AddDays(4), 19, 5),
                new OrderProduct(42, 2, false, today.AddMonths(1).AddDays(4), 19, 4),
                //Newton Gearloose
                new OrderProduct(43, 2, false, today.AddMonths(1).AddDays(3), 20, 3),
                new OrderProduct(44, 2, false, today.AddMonths(1).AddDays(3), 20, 2),
                //Bouncer Beagle
                new OrderProduct(45, 4, true, today.AddMonths(-2).AddDays(3), 21, 1),
                new OrderProduct(46, 1, true, today.AddMonths(-2).AddDays(3), 21, 17),
                //Clara Cluck
                new OrderProduct(47, 6, true, today.AddMonths(-2).AddDays(9), 22, 16),
                new OrderProduct(48, 5, true, today.AddMonths(-2).AddDays(9), 22, 15),
            };
            //YOUR QUERIES HERE


            //Find the customers from Iceland:

            //var clientsInIceland = from cli in clients
            //                       where cli.Country == Countries.Iceland
            //                       orderby cli.City
            //                       select cli;
            //foreach(var c in clientsInIceland)
            //{
            //    Console.WriteLine("City: "+c.City+", Client name: "+ c.ClientName);
            //}

            //Find the newest orders, define a threshold(today): have not ship yet
            //var newestOrders = from op in orderProducts
            //                   join pr in products on op.ProductId equals pr.Id
            //                   join o in orders on op.OrderId equals o.Id
            //                   join c in clients on o.ClientId equals c.Id

            //                   where op.DateOfShipping > today
            //                   orderby op.DateOfShipping
            //                   select new
            //                   {
            //                       op.DateOfShipping,
            //                       pr.ProductName,
            //                       c.ClientName
            //                   };
            //foreach(var n in newestOrders)
            //{
            //    Console.WriteLine("Date of shipping: "+n.DateOfShipping.ToShortDateString()+", Client: "+n.ClientName+", Product: "+n.ProductName);
            //}

            //Choose only certain 

            //string findThese = "Mouse";
            //var certainClient = from c in clients
            //                    where c.ClientName.Contains(findThese)
            //                    orderby c.City
            //                    select c;
            //foreach (var cc in certainClient)
            //{
            //    Console.WriteLine("City: " + cc.City + ", Name: " + cc.ClientName);
            //}

            //var notShipped = from op in orderProducts
            //                 join o in orders on op.OrderId equals o.Id
            //                 join c in clients on o.ClientId equals c.Id
            //                 join p in products on op.ProductId equals p.Id
            //                 where op.Shipped == false
            //                 orderby op.DateOfShipping
            //                 select new
            //                 {
            //                     op.DateOfShipping,
            //                     op.OrderId,
            //                     c.ClientName,
            //                     p.ProductName
            //                 };

            //foreach (var n in notShipped)
            //{
            //    Console.WriteLine("Date of shipping: " + n.DateOfShipping.ToShortDateString() + ", Client: " + n.ClientName + ", Order ID: " + n.OrderId + ", Product: " + n.ProductName);
            //}

            //var finnish = from c in clients
            //              join o in orders on c.Id equals o.ClientId
            //              join op in orderProducts on o.Id equals op.Id
            //              join p in products on op.ProductId equals p.Id

            //              where c.Country == Countries.Finland
            //              orderby c.ClientName
            //              select new
            //              {
            //                  c.ClientName,
            //                  c.City,
            //                  p.ProductName,
            //                  op.Quantity
            //              };

            //foreach (var f in finnish)
            //{
            //    Console.WriteLine("Client name: " + f.ClientName + ", product name: " + f.ProductName + ", how many ordered: " + f.Quantity + ", city: " + f.City);
            //}

            //Find the customers from Sweden:

            //var clientsInSweden = from cli in clients
            //                       where cli.Country == Countries.Sweden
            //                       orderby cli.City
            //                       select cli;
            //foreach (var c in clientsInSweden)
            //{
            //    Console.WriteLine("City: " + c.City + ", Client name: " + c.ClientName);
            //}

            //Find the newest orders, define a threshold(today): have not ship yet
            //var days = new DateTime(2019,1,15);
            //var oldOrders = from op in orderProducts
            //                join pr in products on op.ProductId equals pr.Id
            //                join o in orders on op.OrderId equals o.Id
            //                join c in clients on o.ClientId equals c.Id

            //                where op.DateOfShipping < days
            //                   orderby op.DateOfShipping
            //                   select new
            //                   {
            //                       op.DateOfShipping,
            //                       pr.ProductName,
            //                       c.ClientName
            //                   };
            //foreach (var n in oldOrders)
            //{
            //    Console.WriteLine("Date of shipping: " + n.DateOfShipping.ToShortDateString() + ", Client: " + n.ClientName + ", Product: " + n.ProductName);
            //}

            //string findTheseName = "uck";
            //var certainClient2 = from c in clients
            //                    where c.ClientName.Contains(findTheseName)
            //                    orderby c.City
            //                    select c;
            //foreach (var cc in certainClient2)
            //{
            //    Console.WriteLine("City: " + cc.City + ", Name: " + cc.ClientName);
            //}

            //var didShip = from op in orderProducts
            //                 join o in orders on op.OrderId equals o.Id
            //                 join c in clients on o.ClientId equals c.Id
            //                 join p in products on op.ProductId equals p.Id
            //                 where op.Shipped == true
            //                 orderby op.DateOfShipping
            //                 select new
            //                 {
            //                     op.DateOfShipping,
            //                     op.OrderId,
            //                     c.ClientName,
            //                     p.ProductName
            //                 };

            //foreach (var n in didShip)
            //{
            //    Console.WriteLine("Date of shipping: " + n.DateOfShipping.ToShortDateString() + ", Client: " + n.ClientName + ", Order ID: " + n.OrderId + ", Product: " + n.ProductName);
            //}

            var icelandic = from c in clients
                          join o in orders on c.Id equals o.ClientId
                          join op in orderProducts on o.Id equals op.Id
                          join p in products on op.ProductId equals p.Id

                          where c.Country == Countries.Iceland
                          orderby c.ClientName
                          select new
                          {
                              c.ClientName,
                              c.City,
                              p.ProductName,
                              op.Quantity
                          };

            foreach (var f in icelandic)
            {
                Console.WriteLine("Client name: " + f.ClientName + ", product name: " + f.ProductName + ", how many ordered: " + f.Quantity + ", city: " + f.City);
            }
        }
    }
}
