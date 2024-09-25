using Microsoft.AspNetCore.Mvc;
using RealEstateAuction.Business.DTOs;
using RealEstateAuction.Business.Services.Interface;

namespace RealEstateAuction.Presentation.Controllers
{
    public class AuthenticationController : Controller
    {
        private readonly IAuthenticationService _authenticationService;

        public AuthenticationController(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> LoginAsync(UserLoginDTO loginDTO)
        {
            if (!ModelState.IsValid)
            {
                TempData["Message"] = "Invalid information";
                return RedirectToAction("Index", "Home");
            }

            var isLogin = await _authenticationService.Login(loginDTO);

            if (isLogin)
            {
                TempData["Message"] = "Login Success";
                return RedirectToAction("Index", "Home");
            }
            else
            {
                TempData["Message"] = "Login fail";
                return RedirectToAction("Index", "Home");
            }

        }
    }
}
