using UserControl.Bll.Models.Enums;

namespace UserControl.Bll.Models;

public record GroupModel(
    long Id,
    GroupCode Code,
    string Description);