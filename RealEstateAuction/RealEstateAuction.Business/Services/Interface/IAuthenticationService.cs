using RealEstateAuction.Business.DTOs;
using RealEstateAuction.Data.Repositories.Interface;

namespace RealEstateAuction.Business.Services.Interface
{
    public interface IAuthenticationService
    {
        public Task<bool> Login(UserLoginDTO loginDTO);
    }
}
