using ECommerceApp.Core.Dtos;
using ECommerceApp.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApp.Core.Services
{
    public interface IIdentityService
    {
        Task<ResultDto> RegisterForAdminAsync(UserRegisterDto model, string role = UserRoles.Admin);
    }
}
