using System.Data.Entity;
using StudentSystem.Models;
using System.Data.Entity.Infrastructure;

namespace StudentSystem.Data
{
    public interface IStudnetSystemDbContext
    {
        IDbSet<Facultet> Facultets { get; set; }
        IDbSet<Lecture> Lecturs { get; set; }
        IDbSet<Subject> Predmets { get; set; }
        IDbSet<Stipendii> Scholarships { get; set; }
        IDbSet<Singin> SingIn { get; set; }
        IDbSet<Specialty> Specialnosti { get; set; }
        IDbSet<Student> Students { get; set; }

        DbSet<TEntity> Set<TEntity>() where TEntity : class;
        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
    }
}