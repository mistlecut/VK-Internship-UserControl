using UserControl.Bll.Models;
using UserControl.Bll.Services.Interfaces;

namespace UserControl.Bll.Services;

public class UserControlService : IUserControlService
{
    public Task AddUser(UserModel user)
    {
        throw new NotImplementedException();
    }

    public Task DeleteUser(int userId)
    {
        throw new NotImplementedException();
    }

    public Task<UserModel[]> GetUsers(int[] usersIds)
    {
        throw new NotImplementedException();
    }
}