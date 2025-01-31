﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DataTransferObjects
{
    public class UserForRegistrationDto
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        [Required(ErrorMessage = "Kullanıcı Adı Boş Geçilemez")]
        public string? UserName { get; set; }
        [Required(ErrorMessage = "Şifre Boş Geçilemez")]
        public string? Password { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public ICollection<string> Roles { get; init; } // init demek tanımlandğı yerde bu ifadenin verilmesi gerektiği anlamı taşır.
    }
}
