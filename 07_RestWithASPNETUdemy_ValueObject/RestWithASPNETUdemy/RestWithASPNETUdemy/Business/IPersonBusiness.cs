using RestWithASPNETUdemy.Data.VO;
using RestWithASPNETUdemy.Model;

namespace RestWithASPNETUdemy.Business
{
    public interface IPersonBusiness

    {
        PersonVO Create(PersonVO person);
        PersonVO Update(PersonVO person);
        PersonVO FindById(long id);
        void Delete(long id);

        List<PersonVO> FindAll();
    }
}
