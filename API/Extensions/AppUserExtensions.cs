using API.DTOs;
using API.Entities;
using API.Interfaces;

namespace API.Extensions
{
    public static class AppUserExtensions
    {
        public static UserDTO ToDto(this AppUser appUser, ITokenService tokenService)
        {
            return new UserDTO
            {
                Id = appUser.Id,
                DisplayName = appUser.DisplayName,
                Email = appUser.Email,
                Token = tokenService.CreateToken(appUser),
            };
        }
    }
}
