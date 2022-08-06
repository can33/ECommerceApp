using ECommerceApp.Core.Dtos;
using ECommerceApp.Core.Enums;
using ECommerceApp.Core.Models;
using ECommerceApp.Core.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;

namespace ECommerceApp.Service.Services
{
    public class IdentityService : IIdentityService
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<AppRole> _roleManager;
        private readonly IConfiguration _configuration;

        public IdentityService(UserManager<AppUser> userManager, RoleManager<AppRole> roleManager, IConfiguration configuration)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _configuration = configuration;
        }
        public async Task<ResultDto> RegisterForAdminAsync(UserRegisterDto model, string role = UserRoles.Admin)
        {
            var userExists = await _userManager.FindByNameAsync(model.Email);
            if (userExists is null)
            {
                AppUser appUser = new()
                {
                    Email = model.Email,
                    UserName = model.UserName,
                    FullName = model.FullName,
                };
                var result = await _userManager.CreateAsync(appUser, model.Password);
                if (result.Succeeded)
                {
                    await CreateRole(role);
                    await _userManager.AddToRoleAsync(appUser, role.ToString());
                    return ResultDto.Success();
                }
            }
            return ResultDto.Failed(new string[] { "An account registered with this username already exists" });
        }
        public async Task CreateRole(string role)
        {
            var roleExists = await _roleManager.RoleExistsAsync(role);

            if (!roleExists)
            {
                await _roleManager.CreateAsync(new AppRole { Name = role });

            }

        }
    }
}
