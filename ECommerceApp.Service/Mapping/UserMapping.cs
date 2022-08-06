using AutoMapper;
using ECommerceApp.Core.Dtos;
using ECommerceApp.Core.Models;

namespace ECommerceApp.Service.Mapping
{
    public class UserMapping : Profile
    {
        public UserMapping()
        {
            CreateMap<AppUser, UserAppDto>().ReverseMap();
        }
    }
}
