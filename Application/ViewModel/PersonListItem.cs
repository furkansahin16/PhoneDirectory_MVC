using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Application.ViewModel
{
    public class PersonListItem
    {
        public int Id { get; set; }
        [Display(Name = "İsim")]
        public string FirstName { get; set; }
        [Display(Name = "Soyisim")]
        public string? LastName { get; set; }
        [Display(Name = "Cep Telefonu")]
        public string? MobilePhone { get; set; }
        [Display(Name = "Ev Telefonu")]
        public string? HomePhone { get; set; }
        [Display(Name = "Başlık")]
        public string? Caption { get; set; }
    }
}
