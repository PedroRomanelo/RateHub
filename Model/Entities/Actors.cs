namespace RateHub.Model.Entities;

public class Actors
{
    public int Id { get; set; }
    public string? Biography { get; set; }
    public DateOnly? BirthDate { get; set; }
    public DateOnly? DeathDate { get; set; }
    public string? Nationality { get; set; }
    public decimal? Height { get; set; }
    public string? Gender { get; set; }
    public required string Name { get; set; }
}