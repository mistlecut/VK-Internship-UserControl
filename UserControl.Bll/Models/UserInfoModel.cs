namespace UserControl.Bll.Models;

public record UserInfoModel(
    int UserId,
    string Login,
    string Password,
    DateTime CreationDate,
    int GroupId,
    string GroupCode,
    string GroupDescription,
    int StateId,
    string StateCode,
    string StateDescription);