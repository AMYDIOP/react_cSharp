using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace APITripAdvisort.Entities
{
    public class User
    {
        [Key]
        public int Id {  get; set; }
        [Required, MaxLength(60)]
        public string Title {  get; set; }
        [Required, MaxLength(20)]

        public String FirstName {  get; set; }
        [Required, MaxLength(30)]

        public String LastName {  get; set; }
        [Required, MaxLength(30),DataType(DataType.EmailAddress)]

        public String Email {  get; set; }
        public Role Role { get; set; }
        [JsonIgnore, MaxLength(30)]

        public String PasswordHash { get; set; }
    }
}
