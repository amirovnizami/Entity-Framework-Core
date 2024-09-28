using Microsoft.EntityFrameworkCore;
using SocialMedia.Project.DAL.Repostories.Abstract;
using SocialMedia.Project.Models;
using SocialMedia.Project.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;


namespace SocialMedia.Project.DAL.Repostories.Concrate
{
    public class BaseRepositories<T> : IRepositories<T> where T : BaseEntity, new()
    {
        readonly SocialMediaDbContext _context;
        readonly DbSet<T> _dbSet;

        public BaseRepositories()
        {
            _context = new SocialMediaDbContext();
            _dbSet = _context.Set<T>();
        }



        public void Add(T entity)
        {
            _dbSet.Add(entity);
            entity.CreatedDate = DateTime.Now;
        }
        public void Delete(int id)
        {
            var entity = _dbSet.FirstOrDefault(x => x.Id == id);
            if (entity != null)
            {
                entity.IsDeleted = true;
            }
            else
            {
                throw new NullReferenceException();
            }
        }
        public IEnumerable<T> GetAll()
        {
            return _dbSet.Where(x => x.IsDeleted == false).ToList();
        }
        public T GetById(int id)
        {
            var entity = _dbSet.Where(x => x.IsDeleted == false).FirstOrDefault(x => x.Id == id);
            if (entity == null)
            {
                throw new Exception();
            }
            return entity;

        }
        public void Update(T entity)
        {
            _dbSet.Update(entity);
        }
        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
