using System;
using System.Threading.Tasks;
using Collectively.Services.Groups.Domain;
using Collectively.Services.Groups.Repositories;
using NLog;

namespace Collectively.Services.Groups.Services
{
    public class UserService : IUserService
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task CreateIfNotFoundAsync(string userId, string name, string role, string avatarUrl)
        {
            var user = await _userRepository.GetAsync(userId);
            if (user.HasValue)
            {
                return;
            }
            Logger.Info($"Creating a new user: '{userId}', name: '{name}', role: '{role}'.");
            user = new User(userId, name, role, avatarUrl);
            await _userRepository.AddAsync(user.Value);
        }
    }
}