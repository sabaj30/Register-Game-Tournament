namespace Tournament.Model.Models
{
    public abstract class User
    {
        public virtual string? UserName { get; set; }
        public virtual string? Email { get; set; }
        public virtual string? Password { get; set; }

    }
}
