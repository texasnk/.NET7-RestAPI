using RestWithASPNETUdemy.Model;
using RestWithASPNETUdemy.Model.Base;

namespace RestWithASPNETUdemy.Repository

{
    public interface IRepository<T> where T : BaseEntity
    {
        T Create(T item);
        T Update(T item);
        T FindById(long id);
        void Delete(long id);

        bool Exists(long id);

        List<T> FindAll();
    }
}
