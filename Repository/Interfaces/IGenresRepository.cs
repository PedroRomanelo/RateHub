using RateHub.Model.Entities;

namespace RateHub.Repository.Interfaces;

public interface IGenresRepository
{
    Task<Genres> InsertAsync(Genres genres);
    Task<bool> UpdateAsync(Genres genres);
    Task<IEnumerable<Genres>> GetAllAsync();
    Task<Genres?> GetByIdAsync(int id);
}