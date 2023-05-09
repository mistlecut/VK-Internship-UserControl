using UserControl.Bll.Models;

namespace UserControl.API.Requests;

public record AddUsersRequest(
    string Login,
    string Password,
    GroupModel Group,
    StateModel State);