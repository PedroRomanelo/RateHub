namespace RateHub.Model.Responses.SeriesDetails;

public class SeriesDetailsResponseDTO
{
    public required string Network { get; set; }
    public required string SeasonsCount { get; set; }
    public required string EpisodesCount { get; set; }
    public TimeSpan? EpisodesDuration { get; set; }
    public bool? Status { get; set; }
}
