using Core.Utilities;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<User> GetUser(int id);
        IDataResult<List<User>> GetAll();
        IResult DeleteUser(User user);
        IResult UpdateUser(User user);
        IResult AddUser(User user);
    }
}

