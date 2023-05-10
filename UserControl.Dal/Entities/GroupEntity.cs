using UserControl.Dal.Entities.Enums;

namespace UserControl.Dal.Entities;

public class GroupEntity : BaseEntity
{
    public GroupCode Code { get; set; }
    public string Description { get; set; }
}