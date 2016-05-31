using StudentSystem.Data;
using StudentSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Repository
{
    class GenericRepository<TEntity> : IGenericRepository<TEntity>where TEntity : class
    {
        public IStudnetSystemDbContext context { get; set; }
        public IDbSet<TEntity> set { get; set; }

        public GenericRepository()
        {
            context = new StudnetSystemDbContext();
            set = context.Set<TEntity>();
        }
        public void Add(TEntity entiti)
        {
            EventInDatabase(entiti, EntityState.Added);
        }

        public IQueryable<TEntity> All()
        {
            return this.set;
        }

        public void Update(TEntity entiti)
        {
            EventInDatabase(entiti, EntityState.Modified);
        }

        public void Delete(TEntity entiti)
        {
            EventInDatabase(entiti, EntityState.Deleted);
        }

        public void SaveChanges()
        {
           
        }

        public void EventInDatabase(TEntity entiti, EntityState state)
        {
            var dbinfo = context.Entry(entiti);
            dbinfo.State = state;
        }
    }
}
