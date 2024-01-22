using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.DTOs
{
    public class UserDto
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email  { get; set; }
        public string Password  { get; set; }
        public string Phone  { get; set; }
        public string Company {get; set;}
        public string Discriminator="Constructor";
        public bool admin  { get; set; }
    }
}