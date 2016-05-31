using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using StudentSystem.Models;

namespace StudentSystem.Data
{
    public class StudnetSystemDbContext : DbContext, IStudnetSystemDbContext
    {
        public StudnetSystemDbContext():base("StudentSystemDB")
        {
        }
        public IDbSet<Student> Students { get; set; }
        public IDbSet<Stipendii> Scholarships { get; set; }
        public IDbSet<Specialty> Specialnosti { get; set; }
        public IDbSet<Subject> Predmets { get; set; }
        public IDbSet<Singin> SingIn { get; set; }
        public IDbSet<Facultet> Facultets { get; set; }
        public IDbSet<Lecture> Lecturs { get; set; }

        public DbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            return this.Set<TEntity>();
        }

    }
}
