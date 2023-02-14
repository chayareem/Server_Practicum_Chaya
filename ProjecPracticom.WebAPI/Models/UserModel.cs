namespace ProjectPracticom.WebAPI.Models
{
    public class UserModel
    {
        public string UserId { get; set; } = null!;

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public DateTime DateOfBirth { get; set; }

        public string maleOrFemale { get; set; } = null!;

        public string Hmo { get; set; } = null!;

    }
}
