using UserControl.Dal.Entities.Enums;

namespace UserControl.Dal.Entities;

public class StateEntity : BaseEntity
{
    public StateCode Code { get; set; }
    public string Description { get; set; }
}