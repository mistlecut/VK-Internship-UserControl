using UserControl.Bll.Models;

namespace UserControl.API.Responses;

public record GetUsersResponse(
    UserModel[] Users);