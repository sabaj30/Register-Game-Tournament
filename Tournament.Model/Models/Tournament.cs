namespace Tournament.Model.Models
{
    public class Tournament
    {
        public int Id { get; set; }
        public DateTime RegisterStartDate { get; set; }
        public DateTime RegisterEndDate { get; set; }
        public DateTime TourneyTime { get; set; }
        public int Price { get; set; }
        public ICollection<Player>? Players { get; set; }
        public ICollection<Transaction>? Transaction { get; set; }

    }
}
