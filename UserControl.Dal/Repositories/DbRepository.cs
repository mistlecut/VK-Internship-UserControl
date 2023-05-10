using Microsoft.EntityFrameworkCore;
using UserControl.Dal.Entities.Interfaces;
using UserControl.Dal.Repositories.Interfaces;

namespace UserControl.Dal.Repositories;

public class DbRepository : IDbRepository
{
    private readonly DataContext _context;

    public DbRepository(DataContext context)
    {
        _context = context;
    }

    public IQueryable<T> Get<T>() where T : class, IEntity 
        => _context.Set<T>().AsQueryable();

    public async Task Add<T>(T newEntity) where T : class, IEntity 
        => await _context.Set<T>().AddAsync(newEntity);

    public async Task Delete<T>(long id) where T : class, IEntity
    {
        var entity = await _context.Set<T>().FirstOrDefaultAsync(x => x.Id == id);
        entity.IsActive = false;
        await Task.Run(() => _context.Update(entity));
    }

    public async Task Update<T>(T entity) where T : class, IEntity
        => await Task.Run(() => _context.Set<T>().Update(entity));

    public async Task<int> SaveChangesAsync() 
        => await _context.SaveChangesAsync();
}