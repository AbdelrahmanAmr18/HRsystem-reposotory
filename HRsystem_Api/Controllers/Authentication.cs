using HRsystem_DataAccess.Context;
using HRsystem_DataAccess.Implementation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HRsystem_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Authentication : ControllerBase
    {
        private readonly AuthService<ApplicationUser> authService;
        private readonly GenericRepository<ApplicationUser> genericRepository;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public Authentication(UserManager<ApplicationUser> userManager, 
                                RoleManager<IdentityRole> roleManager,
                                AuthService<ApplicationUser> authService,
                                GenericRepository<ApplicationUser> genericRepository)
        {
            this.authService = authService;
            this.genericRepository = genericRepository;
            this.userManager = userManager;
            this.roleManager = roleManager;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginModel request)
        {
            var user = genericRepository.GetAll().FirstOrDefault(u => u.UserName == request.UserName);

            if (user == null)
            {
                return Unauthorized();
            }

            var token = authService.GenerateToken(user);

            return Ok(new { Token = token });
        }
    }
}
