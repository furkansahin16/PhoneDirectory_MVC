using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Application.ViewModel
{
    public class PersonCreate
    {
        [Display(Name ="İsim")]
        [MaxLength(20,ErrorMessage ="20 karakterden fazla girilemez")]
        [Required]
        public string FirstName { get; set; }
        [Display(Name = "Soyisim")]
        [MaxLength(20, ErrorMessage = "20 karakterden fazla girilemez")]
        public string? LastName { get; set; }
        [Display(Name ="Cep Telefonu")]
        [DataType(DataType.PhoneNumber)]
        public string? MobilePhone { get; set; }
        [Display(Name = "Ev Telefonu")]
        [DataType(DataType.PhoneNumber)]
        public string? HomePhone { get; set; }
        [Display(Name ="Şirket")]
        public string? CompanyInfo { get; set; }
    }
}
