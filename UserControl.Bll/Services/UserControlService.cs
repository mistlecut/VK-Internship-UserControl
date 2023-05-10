using UserControl.Bll.Models;
using UserControl.Bll.Services.Interfaces;

namespace UserControl.Bll.Services;

public class UserControlService : IUserControlService
{
    public Task AddUser(UserModel user)
    {
        throw new NotImplementedException();
    }

    public Task DeleteUser(long userId)
    {
        throw new NotImplementedException();
    }

    public Task<UserModel[]> GetUsers(long[] usersIds)
    {
        throw new NotImplementedException();
    }
}