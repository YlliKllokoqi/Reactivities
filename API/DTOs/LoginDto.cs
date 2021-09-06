using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTOs
{
    public class LoginDto
    {

        //What we need from the user to let them log in

        public string Email { get; set; }

        public string Password { get; set; }

    }
}
