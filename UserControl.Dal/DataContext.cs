using Microsoft.EntityFrameworkCore;
using UserControl.Dal.Entities;

namespace UserControl.Dal;

public class DataContext : DbContext
{
    public DbSet<UserEntity> Users { get; set; }
    public DbSet<StateEntity> States { get; set; }
    public DbSet<GroupEntity> Groups { get; set; }

    public DataContext(DbContextOptions<DataContext> options)
        : base(options) { }

    public async Task<int> SaveChangesAsync() => await base.SaveChangesAsync();

    public DbSet<T> DbSet<T>() where T : class => Set<T>();

    public new IQueryable<T> Query<T>() where T : class => Set<T>();
}