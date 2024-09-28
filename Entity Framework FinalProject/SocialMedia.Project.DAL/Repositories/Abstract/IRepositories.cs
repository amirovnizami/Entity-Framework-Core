namespace SocialMedia.Project.DAL.Repostories.Abstract;
using SocialMedia.Project.Models;
using SocialMedia.Project.Models.Models;
using System.Collections.Generic;

public interface IRepositories<T> where T : BaseEntity, new()
{
    public void Add(T entity);
    public void Update(T entity);
    T GetById(int id);
    public IEnumerable<T> GetAll();
    public void Delete(int id);
    public void SaveChanges();
}
