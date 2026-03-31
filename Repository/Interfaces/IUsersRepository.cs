using RateHub.Model.Entities;

namespace RateHub.Repository.Interfaces;

public interface IUsersRepository
{
    Task<Users> InsertAsync(Users user);
    Task<bool> UpdateAsync(Users user); 
    Task<Users> GetByIdAsync(int id);
}
