using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lensaku.Model.User
{
    public class UserModel
    {
        public Guid UserID { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string UserNickName { get; set; }
        public string UserEmail { get; set; }
        public int UserRole { get; set; }
    }
}
