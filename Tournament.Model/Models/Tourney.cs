namespace Tournament.Model.Models
{
    public class Tourney
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public ICollection<Player>? Players { get; set; }

    }
}
