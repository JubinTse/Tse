using WebTse.Modules;

namespace WebTse.Services
{
    public class UserService
    {
        User[] users = new User[10]
        {
            new User() { Name = "zhangsan", Email = "zhangsan@outlook.com", Id = 1, Password = "123abc", Phone = 88888888},
            new User() { Name = "zhangsan", Email = "zhangsan@outlook.com", Id = 2, Password = "123abc", Phone = 88888888},
            new User() { Name = "zhangsan", Email = "zhangsan@outlook.com", Id = 3, Password = "123abc", Phone = 88888888},
            new User() { Name = "zhangsan", Email = "zhangsan@outlook.com", Id = 4, Password = "123abc", Phone = 88888888},
            new User() { Name = "zhangsan", Email = "zhangsan@outlook.com", Id = 5, Password = "123abc", Phone = 88888888},
            new User() { Name = "zhangsan", Email = "zhangsan@outlook.com", Id = 6, Password = "123abc", Phone = 88888888},
            new User() { Name = "zhangsan", Email = "zhangsan@outlook.com", Id = 7, Password = "123abc", Phone = 88888888},
            new User() { Name = "zhangsan", Email = "zhangsan@outlook.com", Id = 8, Password = "123abc", Phone = 88888888},
            new User() { Name = "zhangsan", Email = "zhangsan@outlook.com", Id = 9, Password = "123abc", Phone = 88888888},
            new User() { Name = "zhangsan", Email = "zhangsan@outlook.com", Id = 10, Password = "123abc", Phone = 88888888}
        };

        public IEnumerable<User>? Get()
        {
            return users;
        }

        public User? Get(int id)
        {
            foreach (var item in users)
            {
                if (item.Id == id)
                    return item;
            }
            return null;
        }

        public void Post(User value)
        {
        }

        public void Put(int id, User value)
        {
        }

        public void Delete(int id)
        {
        }
        
        public int SignIn(User value)
        {
            foreach (var item in users)
            {
                if (value.Name == item.Name && value.Password == item.Password)
                {
                    return 1;
                }
            }
            return 0;
        }

        public int SignUp(User user)
        {
            user.Id = users.Length + 1;
            return 1;
        }
    }
}
