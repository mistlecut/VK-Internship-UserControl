using UserControl.Bll.Models.Enums;

namespace UserControl.Bll.Models;

public record StateModel(
    long Id,
    StateCode Code,
    string Description);