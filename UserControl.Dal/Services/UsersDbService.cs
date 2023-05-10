using UserControl.Dal.Entities;
using UserControl.Dal.Repositories.Interfaces;
using UserControl.Dal.Services.Interfaces;

namespace UserControl.Dal.Services;

public class UsersDbService : IUserDbService
{
    private readonly IDbRepository _dbRepository;
    
    public UsersDbService(IDbRepository dbRepository)
    {
        _dbRepository = dbRepository;
    }

    public async Task Add(UserEntity user)
    {
        await _dbRepository.Add(user);
        await _dbRepository.SaveChangesAsync();
    }

    public async Task Delete(long id)
    {
        await _dbRepository.Delete<UserEntity>(id);
        await _dbRepository.SaveChangesAsync();
    }

    public Task<UserEntity> Get(long[] ids)
    {
        throw new NotImplementedException();
    }
}