using System.Collections;

namespace GameStore.WebAPI.Model
{
    public class Customer
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? PhoneNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public IEnumerable<Order>? Orders { get; set; }

        public Customer()
        {

        }
        public Customer(int id, string name, string phoneNumber, DateTime birthDate)
        {
            this.Id = id;
            this.Name = name;
            this.PhoneNumber = phoneNumber;
            this.BirthDate = birthDate;
        }

    }
}