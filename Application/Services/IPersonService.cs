using Application.ViewModel;
using Domain.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public interface IPersonService
    {
        void Add(PersonCreate createPerson);
        void Delete(int id);
        List<PersonListItem> GetAll();
        List<PersonListItem> GetAllByExpression(Expression<Func<Person, bool>> expression);
        PersonDetail GetById(int id);
        void Edit(PersonDetail updatedPerson);
    }
}
