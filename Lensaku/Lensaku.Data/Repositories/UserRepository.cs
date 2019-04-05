using Lensaku.Data.Infrastructure;
using Lensaku.Model.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lensaku.Data.Repositories
{
    public class UserRepository : RepositoryBase<UserModel>, IUserRepository
    {
        public UserRepository(IDbFactory DbFactory) : base(DbFactory) { }
    }
    public interface IUserRepository : IRepository<UserModel>
    {
    }
}
