using Domain.Entities.Abstract;

namespace Domain.Entities.Concrete
{
    public class Person : IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string? LastName { get; set; }
        public string? CompanyInfo { get; set; }
        public string? Caption { get; set; }
        public string? MobilePhone { get; set; }
        public string? HomePhone { get; set; }
        public string? Note { get; set; }
        public string? NickName { get; set; }
        public string? WebSite { get; set; }
        public DateTime? BirthDate { get; set; }
        public string? Address { get; set; }
    }
}
