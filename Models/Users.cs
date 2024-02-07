using static System.Net.Mime.MediaTypeNames;

namespace Pelicans_RarePublishing.Models
{
    public class Users
    {
        public int Id { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? Email { get; set; }

        public string? Bio { get; set; }

        public string? Username { get; set; }

        public string? Password { get; set; }

        public String? ProfileImageUrl { get; set; }

        public DateTime? CreatedOn { get; set; }

        public bool? Active { get; set; }
    }
}
