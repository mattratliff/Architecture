using Architecture.Domain;
using Architecture.Model;
using DotNetCore.EntityFrameworkCore;
using DotNetCore.Mapping;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Architecture.Database
{
    public sealed class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(Context context) : base(context) { }

        public Task<long> GetAuthIdAsync(long id)
        {
            return Queryable.Where(user => user.Id == id).Select(user => user.Auth.Id).SingleOrDefaultAsync();
        }

        public Task<UserModel> GetByIdAsync(long id)
        {
            return Queryable.Project<User, UserModel>().SingleOrDefaultAsync(user => user.Id == id);
        }

        public Task UpdateStatusAsync(User user)
        {
            return UpdatePartialAsync(user.Id, new { user.Status });
        }
    }
}
