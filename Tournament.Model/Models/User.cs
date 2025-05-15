using System.ComponentModel.DataAnnotations;

namespace Tournament.Model.Models
{
    public class User
    {
        public int Id { get; set; }
        public virtual string? UserName { get; set; }

        [Required]
        [EmailAddress]
        [MaxLength(100)]
        public virtual string? Email { get; set; }
        public virtual string? PasswordHash { get; set; }
        public DateTime LastLoginDate { get;set; }
        public DateTime RegistrationDate { get; set; }
        public ICollection<Transaction>? Transactions { get; set; }
        public ICollection<Game>? Games { get; set; }
        public ICollection<Team>? Teams { get; set; }



    }
}
