using UserControl.Dal.Entities.Interfaces;

namespace UserControl.Dal.Entities;

public class BaseEntity : IEntity
{
    public long Id { get; set; }
    
    public bool IsActive { get; set; } = true;
}