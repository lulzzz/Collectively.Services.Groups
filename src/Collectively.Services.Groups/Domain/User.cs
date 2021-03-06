using Collectively.Common.Domain;

namespace Collectively.Services.Groups.Domain
{
    public class User : IdentifiableEntity
    {
        public string UserId { get; protected set; }
        public string Name { get; protected set; }
        public string Role { get; protected set; }

        protected User()
        {
        }

        public User(string userId, string name, string role)
        {
            UserId = userId;
            Name = name;
            Role = role;
        }

        public void SetName(string name)
        {
            Name = name;
        }
    }
}