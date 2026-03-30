namespace RateHub.Model.Requests.Users;

public class UsersUpdateDTO
{
    public string? Name { get; set; }
    public string? Email { get; set; }
    public string? Password { get; set; }
    public DateTime? UpdatedAt { get; set; }
}