using api.Data;
using api.Entities;
using api.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using System.Security.Cryptography;
using System.Text;
using Interfaces;

namespace api.Controllers
{
    [Authorize]
    public class AccountController : BaseApiController
    {
        private readonly DataContext _context;
        private readonly ITokenServise _tokenServise;
        public AccountController (DataContext context , ITokenServise tokenServise)
        {
            _context = context;
            _tokenServise=tokenServise;
        }

        
        [AllowAnonymous]
        [HttpPost("register")]
        public async Task<ActionResult<UserTokenDto>> Register(UserDto userDto)
        {
            using var hmac = new HMACSHA512();
            var user = new Constructor{
                FirstName=userDto.FirstName ,
                LastName=userDto.LastName,
                UserName=userDto.UserName,
                admin=userDto.admin,
                Email=userDto.Email,
                Company=userDto.Company,
                PasswordHash= hmac.ComputeHash(Encoding.UTF8.GetBytes(userDto.Password)),
                PasswordSalt= hmac.Key,
                Phone=userDto.Phone,            
                };
            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return  new UserTokenDto{
                Id= user.UserId,
                UserName=user.UserName,
                Token=_tokenServise.CreateToke(user)
            };
        }

        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<ActionResult<UserTokenDto>> Login(LoginDto loginDto)
        {
            var user = await _context.Users.SingleOrDefaultAsync(user => user.UserName==loginDto.UserName);
            if(user==null) return Unauthorized("invalid username");
            using var hmac = new HMACSHA512(user.PasswordSalt);
            var computeHash=hmac.ComputeHash(Encoding.UTF8.GetBytes(loginDto.Password));
            for(int i =0 ; i<computeHash.Length; i++){
                if(computeHash[i]!=user.PasswordHash[i]) return Unauthorized("invalid password");
            }
            return new UserTokenDto{
                Id=user.UserId,
                UserName=user.UserName,
                Token=_tokenServise.CreateToke(user)
            }; 
        }
        
        private async Task<bool> UserExists(string userName){
            return await _context.Users.AnyAsync(user=> user.UserName==userName.ToLower());
        }
        
        private async Task<User> GetUser(int id){
             User user = await _context.Users.FindAsync(id);
             return user;
        }        
    }
}
