using Architecture.Domain;
using Architecture.Model;
using DotNetCore.Repositories;
using System.Threading.Tasks;

namespace Architecture.Database
{
    public interface IUserRepository : IRepository<User>
    {
        Task<long> GetAuthIdAsync(long id);

        Task<UserModel> GetByIdAsync(long id);

        Task UpdateStatusAsync(User user);
    }
}
