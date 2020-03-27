using Architecture.Domain;
using DotNetCore.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Architecture.Database
{
    public sealed class AuthRepository : Repository<Auth>, IAuthRepository
    {
        public AuthRepository(Context context) : base(context) { }

        public Task<bool> AnyByLoginAsync(string login)
        {
            return Queryable.AnyAsync(auth => auth.Login == login);
        }

        public Task<Auth> GetByLoginAsync(string login)
        {
            return Queryable.SingleOrDefaultAsync(auth => auth.Login == login);
        }
    }
}
