﻿using System.Drawing;

namespace AkademiPlusProfileImageIdentity.Models
{
    public class UserEditViewModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Image { get; set; }
        public IFormFile ImageFile { get; set; }
        public string Password { get; set; }
    }
}
