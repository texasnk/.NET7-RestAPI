using RestWithASPNETUdemy.Model;

namespace RestWithASPNETUdemy.Repository

{
    public interface IPersonRepository
    {
        Person Create(Person person);
        Person Update(Person person);
        Person FindById(long id);
        void Delete(long id);

        bool Exists(long id);

        List<Person> FindAll();
    }
}
