using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DesignPatterns.RepositoryPattern.IntRep
{
    public interface IRepository<T> where T : BaseEntity
    {
        //Listeleme/Log

        List<T> GetAll();
        List<T> GetActives();
        List<T> GetPassives();
        List<T> GetUpdateds();

        //Modifikasyon
        void Add(T item);
        void Delete(T item); //Pasife cekmek
        void Destroy(T item);
        void Update(T item);

        //Linq
        List<T> Where(Expression<Func<T,bool>> exp);
        bool Any(Expression<Func<T, bool>> exp);
        T FirstOrDefault(Expression<Func<T, bool>> exp);
        object Select(Expression<Func<T, object>> exp);

        //Find
        T Find(int id);



    }
}
