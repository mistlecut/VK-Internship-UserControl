using UserControl.Dal.Entities.Interfaces;

namespace UserControl.Dal.Repositories.Interfaces;

public interface IDbRepository
{
    IQueryable<T> Get<T>() where T : class, IEntity;

    Task Add<T>(T newEntity) where T : class, IEntity;
    
    Task Delete<T>(long id) where T : class, IEntity;
    
    Task Update<T>(T entity) where T : class, IEntity;

    Task<int> SaveChangesAsync();
}