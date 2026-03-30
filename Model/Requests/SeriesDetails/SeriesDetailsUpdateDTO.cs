namespace RateHub.Model.Requests.SeriesDetails
public class SeriesDetailsUpdateDTO
{
    public string? Network { get; set; }
    public string? SeasonsCount { get; set; }
    public string? EpisodesCount { get; set; }
    public TimeSpan? EpisodesDuration { get; set; }
    public bool? Status { get; set; }
}