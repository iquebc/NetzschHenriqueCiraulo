using System.Text.Json.Serialization;

namespace Core.Entities
{
    public class User
    {
        private string id;
        private string name;
        public string Id
        {
            get { return id; }
            private set
            {
                id = Guid.NewGuid().ToString();
            }
        }
        
        public string Name
        {
            get { return name; }
            private set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Name");

                name = value;
            }
        }

        public User(string name)
        {
            Name = name;
        }

        public static User NewUser(string name)
        {
            return new User(name);
        }
    }
}