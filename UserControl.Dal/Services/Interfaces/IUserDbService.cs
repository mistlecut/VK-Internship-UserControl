using UserControl.Dal.Entities;

namespace UserControl.Dal.Services.Interfaces;

public interface IUserDbService
{
    Task Add(UserEntity user);
    
    Task Delete(long id);
    
    Task<UserEntity> Get(long[] ids);
}