using Microsoft.AspNetCore.Mvc;
using UserControl.API.Requests;
using UserControl.API.Responses;
using UserControl.Bll.Models;
using UserControl.Bll.Services.Interfaces;

namespace UserControl.API.Controllers;

[ApiController]
[Route("/v1/[controller]")]
public class UserControlController : ControllerBase
{
    private readonly IUserControlService _userControlService;

    public UserControlController(
        IUserControlService priceCalculatorService)
    {
        _userControlService = priceCalculatorService;
    }
    
    /// <summary>
    /// Метод добавления пользователя
    /// </summary>
    [HttpPost("add")]
    public async Task Add(
        AddUsersRequest request)
    {
        await _userControlService.AddUser(
            new UserModel(request.Login,
                request.Password,
                request.Group,
                request.State));
    }
    
    /// <summary>
    /// Метод удаления пользователей
    /// </summary>
    [HttpPost("delete")]
    public async Task Delete(DeleteUserRequest request)
    {
        await _userControlService.DeleteUser(request.UserId);
    }
    
    /// <summary>
    /// Метод получения пользователей
    /// </summary>
    [HttpPost("get")]
    public async Task<GetUsersResponse> Get(GetUsersRequest request)
    {
        var usersInfo = await _userControlService.GetUsers(request.UsersIds);

        return new GetUsersResponse(usersInfo);
    }
}