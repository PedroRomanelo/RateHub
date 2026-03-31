using RateHub.Model.Entities;

namespace RateHub.Repository.Interfaces;

public interface IMediaRepository
{
    Task<Media> InsertAsync(Media media);
    Task<bool> UpdateAsync(Media media);
    Task<IEnumerable<Media>> GetAllAsync();
    Task<Media?> GetByIdAsync (int id);
    Task<IEnumerable<Media>> GetByGenreAsync (int genreId);
    Task<Media?> GetByTitleAsync(string Title);
    Task<IEnumerable<Reviews>> GetReviewsByMediaIdAsync(int id);
    Task<bool> DeleteAsync(int id);
}
