
namespace DesignPatternExample
{
    public interface IUserRepository
    {
        IEnumerable<UserRepositoryModel> GetAllUsers();
        UserRepositoryModel GetUserById(int id);
        void AddUser(UserRepositoryModel user);
        bool DeleteUser(int id);
        // Other user-related operations
    }
}
