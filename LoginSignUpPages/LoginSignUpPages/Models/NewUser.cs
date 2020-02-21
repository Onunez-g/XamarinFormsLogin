using System;
using System.Collections.Generic;
using System.Text;

namespace LoginSignUpPages.Models
{
    public class NewUser
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string RepeatPassword { get; set; }
    }
}
