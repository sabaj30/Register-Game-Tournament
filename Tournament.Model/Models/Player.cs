namespace Tournament.Model.Models
{
    public class Player : User
    {
        public int Id { get; set; }
        public string? NationalCode { get; set; }
        public Team? Team { get; set; }
        public ICollection<Tourney>? PlayerTournaments { get; set; }
        public ICollection<Register>? Register { get; set; }
    }
}
