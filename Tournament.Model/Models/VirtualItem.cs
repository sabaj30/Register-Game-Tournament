namespace Tournament.Model.Models
{
    public class VirtualItem
    {
        public int Id { get; set; }
        public string? ItemName { get; set; }
        public string? Description { get; set; }
        public int Price { get; set; }
        public string? ItemType { get; set; }
        public int GameId { get; set; }
        public Game? Game { get; set; }
    }
}
