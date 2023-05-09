using UserControl.Bll.Models.Enums;

namespace UserControl.Bll.Models;

public record GroupModel(
    int Id,
    GroupCode Code,
    string Description);