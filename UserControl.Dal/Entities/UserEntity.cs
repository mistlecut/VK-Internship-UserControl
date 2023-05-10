namespace UserControl.Dal.Entities;

public class UserEntity : BaseEntity
{
    public string Login { get; set; }
    public string Password { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.Now;
    public long GroupId { get; set; }
    public long StateId { get; set; }
}