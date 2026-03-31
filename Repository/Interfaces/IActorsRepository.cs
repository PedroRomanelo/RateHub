using RateHub.Model.Entities;

namespace RateHub.Repository.Interfaces;

public interface IActorsRepository
{
    Task<int> InsertAsync (Actors actor);
    Task<bool> UpdateAsync (Actors actor);
    Task<IEnumerable<Actors>> GetAllAsync();
    Task<Actors?> GetByIdAsync(int id); //o id pode nn existir, retornando null 
}
