namespace Tournament.Model.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Genre { get; set; }
        public int Price { get; set; }
        public Register? Register { get; set; }

    }
}
