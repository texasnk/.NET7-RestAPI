using RestWithASPNETUdemy.Model;

namespace RestWithASPNETUdemy.Repository

{
    public interface IBookRepository
    {
        Book Create(Book book);
        Book Update(Book book);
        Book FindById(long id);
        void Delete(long id);

        bool Exists(long id);

        List<Book> FindAll();
    }
}
