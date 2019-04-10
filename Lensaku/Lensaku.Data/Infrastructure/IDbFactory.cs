using Lensaku.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lensaku.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        GeneralEntities Init();
    }
}
