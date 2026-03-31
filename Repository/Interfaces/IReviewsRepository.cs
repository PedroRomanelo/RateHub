using RateHub.Model.Entities;

namespace RateHub.Repository.Interfaces;

public interface IReviewsRepository
{
    Task<Reviews> InsertAsync(Reviews reviews);
    Task<bool> UpdateAsync(Reviews reviews);
    Task<bool> DeleteAsync(int id);
}
