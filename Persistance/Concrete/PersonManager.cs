using Application.Services;
using Application.ViewModel;
using Domain.Entities.Concrete;
using Domain.Repository.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Concrete
{
    public class PersonManager<TContext> : IPersonService<TContext>
    {
        private readonly

        public PersonManager(PersonRepo<TContext> repo)
        {

        }
        public void Add(PersonCreate createPerson)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<PersonDetail> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<PersonDetail> GetAllByExpression(Expression<Func<Person, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public PersonListItem GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
