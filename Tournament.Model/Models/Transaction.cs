namespace Tournament.Model.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public int Amount { get; set; }
        public DateTime TransactionDate { get; set; }
        public string? TransactionType { get; set; }
        public int UserId { get; set; }
        public User? User { get; set; }
        public int GameId { get; set; }
        public Game? Game { get; set; }

    }
}
