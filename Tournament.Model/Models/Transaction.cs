namespace Tournament.Model.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public int TransactionCode { get; set; }
        public int PlayerId { get; set; }
        public Player? Player { get; set; }
        public int TournamentId { get; set; }
        public Tournament? Tournament { get; set; }
    }
}
