using RateHub.Model.Enums;

namespace RateHub.Model.Requests.Actors;

public class ActorsRegisterDTO
{
    public required string Name { get; set; }
    public string? Biography { get; set; }
    public DateOnly? BirthDate { get; set; }
    public DateOnly DeathDate { get; set; }
    public CountryCode? Nationality { get; set; }
    public decimal? Height { get; set; }
    public string? Gender { get; set; }
}
