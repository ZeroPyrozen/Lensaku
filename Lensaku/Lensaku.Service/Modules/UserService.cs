using Lensaku.Data.Repositories;
using Lensaku.Model.User;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lensaku.Service.Modules
{
    public interface IUserService
    {
        Task<UserModel> GetUser(string Username, string Password);
    }
    public class UserService : IUserService
    {
        //Repository
        private readonly IUserRepository UserRepository;

        public UserService(IUserRepository UserRepository)
        {
            this.UserRepository = UserRepository;
        }

        public async Task<UserModel> GetUser(string Username, string Password)
        {
            var Param = new[] 
                { new SqlParameter("@Username", Username),new SqlParameter("@Password", Password) };
            return await UserRepository.ExecSPToSingleAsync("[dbo].[ln_General_Login] @Username, @Password", Param);
        }
    }
}
