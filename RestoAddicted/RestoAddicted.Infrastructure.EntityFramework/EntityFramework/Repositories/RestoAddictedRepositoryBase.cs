using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Abp.Domain.Entities;
using Abp.Domain.Repositories.EntityFramework;

namespace RestoAddicted.EntityFramework.Repositories
{
    public abstract class RestoAddictedRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<RestoAddictedDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
    }

    public abstract class RestoAddictedRepositoryBase<TEntity> : RestoAddictedRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {

    }
}
