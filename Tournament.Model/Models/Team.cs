namespace Tournament.Model.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string? TeamName { get; set; }
        public string? LeaderUserId { get; set; }
        public int GameId { get; set; }
        public Game? Game { get; set; }
        public ICollection<User>? Users { get; set; }

    }
}
