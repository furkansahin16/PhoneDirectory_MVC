using Domain.Data;
using Domain.Entities.Concrete;
using Domain.Repository.Abstract;

namespace Domain.Repository.Concrete
{
    public class PersonRepo : Repository<Person,DirectoryDbContext>, IPersonRepo
    {
    }
}
