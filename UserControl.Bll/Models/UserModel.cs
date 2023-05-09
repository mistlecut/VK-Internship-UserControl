namespace UserControl.Bll.Models;

public record UserModel(
    string Login,
    string Password,
    GroupModel Group,
    StateModel State);