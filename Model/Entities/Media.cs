using System.ComponentModel.DataAnnotations.Schema;

namespace RateHub.Model.Entities;

public class Media
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public required string Type { get; set; }
    public DateOnly? RealeseDate { get; set; }
    public int? Duration { get; set; }
    public string? OriginalLanguage { get; set; }

    [Column(TypeName = "varbinary(max)")]
    public byte[]? Poster { get; set; }
    public decimal? AverageScore { get; set; }
    public string? Rating { get; set; }
}
