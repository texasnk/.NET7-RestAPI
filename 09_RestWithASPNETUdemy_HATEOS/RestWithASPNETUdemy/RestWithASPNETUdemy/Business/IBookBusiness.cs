using RestWithASPNETUdemy.Model;

namespace RestWithASPNETUdemy.Business
{
    public interface IBookBusiness

    {
        BookVO Create(BookVO book);
        BookVO Update(BookVO book);
        BookVO FindById(long id);
        void Delete(long id);

        List<BookVO> FindAll();
    }
}
