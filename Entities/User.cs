
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace api.Entities
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email  { get; set; }
        public byte[] PasswordHash  { get; set; }
        public byte[] PasswordSalt  { get; set; }
        public string Phone  { get; set; }
        public bool admin  { get; set; }
        public ICollection<Showroom> Showrooms { get; set; }

    }
}