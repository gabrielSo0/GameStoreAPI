namespace GameStore.WebAPI.Model
{
    public class GameOrder
    {
        public int GameId { get; set; }
        public Game? Game { get; set; }
        public int OrderId { get; set; }
        public Order? Order { get; set; }

        public GameOrder()
        {
            
        }
        public GameOrder(int gameId, int orderId)
        {
            this.GameId = gameId;
            this.OrderId = orderId;
        }
    }
}