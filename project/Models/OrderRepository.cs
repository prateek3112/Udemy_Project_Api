using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project.Models
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext _appDbContext;



        public OrderRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
            
        }


        public void CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;

            _appDbContext.Orders.Add(order);

           

            _appDbContext.SaveChanges();
        }
    }
}
