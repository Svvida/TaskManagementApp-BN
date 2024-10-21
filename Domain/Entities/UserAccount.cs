using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class UserAccount
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public UserAccount(string id, string email, string password)
        {
            Id = id;
            Email = email;
            Password = password;
        }
    }
}
