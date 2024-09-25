using System.ComponentModel.DataAnnotations;

namespace RealEstateAuction.Business.DTOs
{
    public class UserLoginDTO
    {
        [EmailAddress(ErrorMessage = "Vui lòng nhập đúng địa chỉ email!")]
        public string Email { get; set; } = null!;

        public string Password { get; set; } = null!;
    }
}
