namespace UserControl.Bll.Models;

public record UserInfoModel(
    long UserId,
    string Login,
    string Password,
    DateTime CreationDate,
    long GroupId,
    string GroupCode,
    string GroupDescription,
    long StateId,
    string StateCode,
    string StateDescription);