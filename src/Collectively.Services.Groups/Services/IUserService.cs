using System.Threading.Tasks;

namespace Collectively.Services.Groups.Services
{
    public interface IUserService
    {
        Task CreateIfNotFoundAsync(string userId, string name, string role);
        Task UpdateNameAsync(string userId, string name);
        Task DeleteAsync(string userId);
    }
}