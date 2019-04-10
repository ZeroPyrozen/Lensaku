using Lensaku.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lensaku.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        GeneralEntities dbContext;


        public GeneralEntities Init()
        {
            return dbContext ?? (dbContext = new GeneralEntities());
        }



        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
