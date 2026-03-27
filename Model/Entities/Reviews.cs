namespace RateHub.Model.Entities;

public class Reviews
{
    public int Media_id { get; set; }
    public int User_id { get; set; }
    public string? Content {  get; set; }
    public required int Score { get; set; }
    public DateTime? CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}
