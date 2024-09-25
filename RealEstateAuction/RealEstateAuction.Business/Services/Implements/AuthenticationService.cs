using RealEstateAuction.Business.DTOs;
using RealEstateAuction.Business.Services.Interface;
using RealEstateAuction.Data.Repositories.Interface;

namespace RealEstateAuction.Business.Services.Implements
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IUserRepository _userRepository;

        public AuthenticationService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<bool> Login(UserLoginDTO loginDTO)
        {
            var user = await _userRepository.GetUserWithPredicate(x => x.Email == loginDTO.Email && x.Password == loginDTO.Password);

            return user != null;
        }
    }
}
