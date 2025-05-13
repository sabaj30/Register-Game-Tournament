namespace Tournament.Model.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public ICollection<Tournament>? PlayerTournaments { get; set; }
        public ICollection<Transaction>? Transactions { get; set; }
    }
}
