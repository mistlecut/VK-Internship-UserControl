using UserControl.Bll.Models;

namespace UserControl.Bll.Services.Interfaces;

public interface IUserControlService
{
    Task AddUser(UserModel user);

    Task DeleteUser(long userId);

    Task<UserModel[]> GetUsers(long[] usersIds);
}