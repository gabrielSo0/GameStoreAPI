using GameStore.WebAPI.Model;
using Microsoft.EntityFrameworkCore;
using System;

namespace GameStore.WebAPI.Data
{
    public class GameStoreContext : DbContext
    {
        public DbSet<Game>? Games { get; set; }
        public DbSet<Customer>? Customers { get; set; }
        public DbSet<Order>? Orders { get; set; }
        public DbSet<GameOrder>? GamesOrders { get; set; }
        public GameStoreContext(DbContextOptions<GameStoreContext> dbConectionString) : base(dbConectionString)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<GameOrder>()
                .HasKey(GO => new { GO.GameId, GO.OrderId });

            builder.Entity<Game>()
                .HasData(new List<Game>() {
                    new Game(1, "Ghost Of Tsushima", "Action", 64.11),
                    new Game(2, "Marvels Guardians of the Galaxy", "Action", 29.99),
                    new Game(3, "The Witcher 3", "RPG", 33.99),
                    new Game(4, "God of War", "Action", 19.99)
                });
            
            builder.Entity<Customer>()
                .HasData(new List<Customer>() {
                    new Customer(1, "Gabriel", "Silva", "123456", DateTime.ParseExact("01/14/1998", "MM/dd/yyyy", null)),
                    new Customer(2, "John", "Wick", "456789", DateTime.ParseExact("02/15/1991", "MM/dd/yyyy", null)),
                    new Customer(3, "Darth", "Vader", "789456", DateTime.ParseExact("07/30/1980", "MM/dd/yyyy", null)),
                    new Customer(4, "Jessica", "Laura", "515846", DateTime.ParseExact("03/23/2000", "MM/dd/yyyy", null))
                });
            
            builder.Entity<Order>()
                .HasData(new List<Order>() {
                    new Order(1, DateTime.ParseExact("06/01/2020", "MM/dd/yyyy", null), 1),
                    new Order(2, DateTime.ParseExact("05/07/2020", "MM/dd/yyyy", null), 2),
                    new Order(3, DateTime.ParseExact("02/06/2020", "MM/dd/yyyy", null), 3),
                    new Order(4, DateTime.ParseExact("01/15/2020", "MM/dd/yyyy", null), 4)
                });
            
            builder.Entity<GameOrder>()
                .HasData(new List<GameOrder>() {
                    new GameOrder() { GameId = 1, OrderId = 1 },
                    new GameOrder() { GameId = 1, OrderId = 2 },
                    new GameOrder() { GameId = 1, OrderId = 3 },
                    new GameOrder() { GameId = 2, OrderId = 1 },
                    new GameOrder() { GameId = 2, OrderId = 2 },
                    new GameOrder() { GameId = 3, OrderId = 4 },
                    new GameOrder() { GameId = 3, OrderId = 3 },
                    new GameOrder() { GameId = 4, OrderId = 1 },
                    new GameOrder() { GameId = 4, OrderId = 3 },
                    new GameOrder() { GameId = 4, OrderId = 4 }
                });
            

        }
    }
}