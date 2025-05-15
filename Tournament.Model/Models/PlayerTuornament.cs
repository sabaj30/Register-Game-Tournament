namespace Tournament.Model.Models
{
    public class PlayerTuornament
    {
        public int Id { get; set; }
        public int PlayerId { get; set; }
        public Player? Player { get; set; }
        public int TournamentId { get; set; }
        public Tourney? Tournament { get; set; }
    }
}
