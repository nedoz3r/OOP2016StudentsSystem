using StudentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Repository
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        IQueryable<TEntity> All();
        void Add(TEntity entiti);
        void Delete(TEntity entiti);
        void Update(TEntity entiti);
        void SaveChanges();


    }
}
