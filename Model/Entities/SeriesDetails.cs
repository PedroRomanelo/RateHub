namespace RateHub.Model.Entities;

public class SeriesDetails
{
    public int Media_Id { get; set; }
    public required string Network { get; set; }
    public required string SeasonsCount { get; set; }
    public required string EpisodesCount { get; set; }
    public TimeSpan? EpisodesDuration { get; set; }
    public bool? Status { get; set; }
}
