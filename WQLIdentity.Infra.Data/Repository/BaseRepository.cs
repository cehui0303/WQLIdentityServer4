﻿using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace WQLIdentity.Infra.Data.Repository
{
    public class BaseRepository<TEntity, TDbcontext>
        where TEntity : class
        where TDbcontext : DbContext
    {
        protected readonly TDbcontext Db;
        protected readonly DbSet<TEntity> DbSet;
        public BaseRepository(TDbcontext applicationDb)
        {
            Db = applicationDb;
            DbSet = Db.Set<TEntity>();
        }
        public virtual void Add(TEntity obj)
        {
            DbSet.Add(obj);
        }

        public virtual TEntity GetById<T>(T id)
        {
            return DbSet.Find(id);
        }

        public virtual IQueryable<TEntity> GetAll()
        {
            return DbSet;
        }

        public virtual void Update(TEntity obj)
        {
            DbSet.Update(obj);
        }

        public virtual void Remove(TEntity entity)
        {
            DbSet.Remove(entity);
        }

        public virtual int SaveChanges()
        {
            return Db.SaveChanges();
        }

        public virtual async Task AddAsync(TEntity obj)
        {
            await DbSet.AddAsync(obj);
        }

        public virtual async Task<TEntity> GetByIdAsync<T>(T id)
        {
            return await DbSet.FindAsync(id);
        }

        public virtual async Task<int> SaveChangesAsync()
        {
            return await Db.SaveChangesAsync();
        }
    }
}
