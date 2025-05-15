namespace Tournament.Model.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Genre { get; set; }
        public string? Description { get; set; }
        public string? Developer { get; set; }
        public ICollection<User>? Users { get; set; }
        public ICollection<Transaction>? Transactions { get; set; }
        public ICollection<VirtualItem>? VirtualItems { get; set; }

    }
}
