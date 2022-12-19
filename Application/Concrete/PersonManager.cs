using Application.Services;
using Application.ViewModel;
using Domain.Entities.Concrete;
using Domain.Repository.Abstract;
using System.Linq.Expressions;

namespace Application.Concrete
{
    public class PersonManager : IPersonService
    {
        private readonly IPersonRepo _repo;
        public PersonManager(IPersonRepo repo)
        {
            _repo = repo;
        }
        public void Add(PersonCreate createPerson)
        {
            Person person = new()
            {
                FirstName = createPerson.FirstName,
                LastName = createPerson.LastName,
                MobilePhone = createPerson.MobilePhone,
                HomePhone = createPerson.HomePhone,
                CompanyInfo = createPerson.CompanyInfo
            };
            _repo.Add(person);
        }

        public void Delete(int id)
        {
            Person person = _repo.Get(x => x.Id == id);
            _repo.Delete(person);
        }

        public void Edit(PersonDetail updatedPerson)
        {
            Person person = _repo.Get(x => x.Id == updatedPerson.Id);
            person.FirstName = updatedPerson.FirstName;
            person.LastName = updatedPerson.LastName;
            person.MobilePhone = updatedPerson.MobilePhone;
            person.HomePhone = updatedPerson.HomePhone;
            person.BirthDate = updatedPerson.BirthDate;
            person.Address = updatedPerson.Address;
            person.Caption = updatedPerson.Caption;
            person.CompanyInfo = updatedPerson.CompanyInfo;
            person.Note = updatedPerson.Note;
            person.NickName = updatedPerson.NickName;
            person.WebSite = updatedPerson.WebSite;
            _repo.Update(person);
        }

        public List<PersonListItem> GetAll()
        {
            List<PersonListItem> people = _repo.GetAll().Select(x => new PersonListItem()
            {
                Id = x.Id,
                FirstName = x.FirstName,
                LastName = x.LastName,
                MobilePhone = x.MobilePhone,
                HomePhone = x.HomePhone,
                Caption = x.Caption
            }).ToList();

            return people;
        }
        
        public List<PersonListItem> GetAllByExpression(Expression<Func<Person, bool>> expression)
        {
            List<PersonListItem> people = _repo.GetAll(expression).Select(x => new PersonListItem()
            {
                Id = x.Id,
                FirstName = x.FirstName,
                LastName = x.LastName,
                MobilePhone = x.MobilePhone,
                HomePhone = x.HomePhone
            }).ToList();

            return people;
        }

        public PersonDetail GetById(int id)
        {
            Person person = _repo.Get(x => x.Id == id);
            PersonDetail personListItem = new()
            {
                Id = person.Id,
                FirstName = person.FirstName,
                LastName = person.LastName,
                MobilePhone = person.MobilePhone,
                HomePhone = person.HomePhone,
                Caption = person.Caption,
                Address = person.Address,
                BirthDate = person.BirthDate,
                CompanyInfo = person.CompanyInfo,
                WebSite = person.WebSite,
                Note = person.Note,
                NickName = person.NickName,
            };
            return personListItem;
        }
    }
}
