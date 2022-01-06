using System.Collections.Generic;

namespace GameStore.WebAPI.Model
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime DateOrder { get; set; }
        public int CustomerId { get; set; }
        public Customer? Customer { get; set; }
        public IEnumerable<Game>? Games { get; set; }
        public Order()
        {
            
        }
        public Order(int id, DateTime dateOrder, int customerId)
        {
            this.Id = id;
            this.DateOrder = dateOrder;
            this.CustomerId = customerId;
        }
    }
}