using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Application.ViewModel
{
    public class PersonDetail
    {
        public int Id { get; set; }
        [Display(Name = "İsim")]
        [MaxLength(20, ErrorMessage = "20 karakterden fazla girilemez")]
        [Required]
        public string FirstName { get; set; }
        [Display(Name = "Soyisim")]
        [MaxLength(20, ErrorMessage = "20 karakterden fazla girilemez")]
        public string? LastName { get; set; }
        [Display(Name = "Şirket")]
        public string? CompanyInfo { get; set; }
        [Display(Name ="Başlık")]
        public string? Caption { get; set; }
        [Display(Name = "Cep Telefonu")]
        [DataType(DataType.PhoneNumber)]
        public string? MobilePhone { get; set; }
        [Display(Name = "Ev Telefonu")]
        [DataType(DataType.PhoneNumber)]
        public string? HomePhone { get; set; }
        [Display(Name ="Not")]
        public string? Note { get; set; }
        [Display(Name ="Nick")]
        public string? NickName { get; set; }
        [Display(Name ="Web Sitesi")]
        public string? WebSite { get; set; }
        [Display(Name = "Doğum Tarihi")]
        public DateTime? BirthDate { get; set; }
        [Display(Name ="Adres")]
        public string? Address { get; set; }
    }
}
