using System.ComponentModel.DataAnnotations;

namespace DoAn_LapTrinhWeb.Models
{

    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
    public class ExternalLoginListViewModel
    {
        public string ReturnUrl { get; set; }
    }
    public class Sigin
    {
        public int account_id { get; set; }
        //Email
        [Required(ErrorMessage = "Nhập email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        //Password
        [Required(ErrorMessage = "Nhập mật khẩu")]
        [DataType(DataType.Password)]
        public string password { get; set; }
        //Roles
        [StringLength(1)] public string Role { get; set; }
        //Name
        public string Name { get; set; }
        //Avatar
        public string Avatar { get; set; }
    }
}