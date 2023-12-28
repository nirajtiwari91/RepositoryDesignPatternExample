namespace DesignPatternExample
{
    public class UserService //Data access layer
    {
        private List<User> _users = new List<User>(); // Simulating a data store

        public IEnumerable<User> GetAllUsers()
        {
            return _users;
        }

        public User GetUserById(int id)
        {
            return _users.FirstOrDefault(u => u.Id == id);
        }

        public void AddUser(User user)
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

        // Other user-related operations
    }
}

