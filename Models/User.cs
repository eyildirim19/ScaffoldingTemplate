using System.ComponentModel.DataAnnotations;

namespace ScaffoldingTemplate.Models
{
    public class User
    {
        public string UserId { get; set; }

        [Display(Name = "Kullanıcı Adı")]
        [Required(ErrorMessage = "Kullanıcı Aıd alanı zorunludur")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Kullanıcı Adı alanı min. 3 karakter max. 20 karakter olabilir")]
        public string UserName { get; set; }


        [Display(Name = "Şifre")]
        [Required(ErrorMessage = "Şifre alanı zorunludur")]
        [StringLength(10, MinimumLength = 3, ErrorMessage = "Şifre Adı alanı min. 3 karakter max. 10 karakter olabilir")]
        public string Password { get; set; }

        [Display(Name = "Adı")]
        public string Name { get; set; }

        [Display(Name = "SoyAdı")]
        public string SurName { get; set; }
    }
}
