using System.Collections;

namespace GameStore.WebAPI.Model
{
    public class Game
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Genre { get; set; }
        public double Price { get; set; }
        public string? Brand { get; set; }
        public string? Plataform { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string? NumberOfPlayers { get; set; }
        public string? Description { get; set; }
        public IEnumerable<Order>? Orders { get; set; }

        public Game()
        {
            
        }
        public Game(int id, string name, string genre, double price)
        {
            this.Id = id;
            this.Name = name;
            this.Genre = genre;
            this.Price = price;
        }


    }
}