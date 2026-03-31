namespace RateHub.Model.Responses.Reviews;

public class ReviewsResponseDTO
{
    public required int Media_id { get; set; }
    public required int User_id { get; set; }
    public string? Content { get; set; }
    public required int Score { get; set; }
    public DateTime? CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}
