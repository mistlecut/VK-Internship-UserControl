using UserControl.Bll.Models.Enums;

namespace UserControl.Bll.Models;

public record StateModel(
    int Id,
    StateCode Code,
    string Description);