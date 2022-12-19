using Domain.Data;
using Domain.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repository.Abstract
{
    public interface IPersonRepo : IRepository<Person,DirectoryDbContext>
    {
    }
}
