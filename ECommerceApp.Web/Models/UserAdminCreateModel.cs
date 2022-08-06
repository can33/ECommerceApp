using System.ComponentModel.DataAnnotations;

namespace ECommerceApp.Web.Models
{
    public class UserAdminCreateModel
    {
        [Required(ErrorMessage = "Kullanıcı adı gereklidir.")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Email adresi gereklidir.")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Password alanı gereklidir.")]
        public string Password { get; set; }
    }
}
