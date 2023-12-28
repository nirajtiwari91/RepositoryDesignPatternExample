
namespace DesignPatternExample
{
    public class UserRepository : IUserRepository //Data access layer
    {
        private readonly List<UserRepositoryModel> _users = new List<UserRepositoryModel>(); // Simulating a data store

        public IEnumerable<UserRepositoryModel> GetAllUsers()
        {
            return _users;
        }

        public UserRepositoryModel GetUserById(int id)
        {
            return _users.FirstOrDefault(u => u.Id == id);
        }

        public void AddUser(UserRepositoryModel user)
        {
            _users.Add(user);
        }

        public bool DeleteUser(int id)
        {
            var user = _users.FirstOrDefault(u => u.Id == id);
            if (user != null)
            {
                _users.Remove(user);
                return true;
            }
            return false;
        }
    }
}
