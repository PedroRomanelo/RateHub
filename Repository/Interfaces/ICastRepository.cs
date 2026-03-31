using RateHub.Model.Entities;

namespace RateHub.Repository.Interfaces;

public interface ICastRepository
{
    Task<Cast> InsertAsync(Cast cast);
    Task<bool> UpdateAsync(Cast cast);
    Task<Cast?> GetByIdAsync(int id);
}
