namespace Tournament.Model.Models
{
    public class Register
    {
        public int Id { get; set; }
        public DateTime RegisterTime { get; set; }
        public ICollection<Game>? Games { get; set; }
        public  ICollection<Player>? Players { get; set; }
        public ICollection<Transaction>? Transaction { get; set; }

    }
}
