namespace DesignPatternExample
{
    public class UserServiceRepository //Buisness logic
    {
        private readonly IUserRepository _userRepository;

        public UserServiceRepository(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public IEnumerable<UserRepositoryModel> GetAllUsers()
        {
            return _userRepository.GetAllUsers();
        }

        public UserRepositoryModel GetUserById(int id)
        {
            return _userRepository.GetUserById(id);
        }

        public void AddUser(UserRepositoryModel user)
        {
            _userRepository.AddUser(user);
        }

        public bool DeleteUser(int id)
        {
            return _userRepository.DeleteUser(id);
        }

        // Other user-related operations
    }
}
