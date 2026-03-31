namespace RateHub.Model.Requests.Users;

public class UsersLoginDTO
{
    public required string Email { get; set; }
    public required string Password { get; set; }
}
