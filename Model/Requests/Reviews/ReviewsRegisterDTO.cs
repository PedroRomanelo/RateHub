namespace RateHub.Model.Requests.Reviews;

public class ReviewsRegisterDTO
{
    public required int Media_id { get; set; }
    public required int User_id { get; set; }
    public string? Content { get; set; }
    public required int Score { get; set; }
    public DateTime? CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}
