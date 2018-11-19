using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Поле должно быть установлено")]
        public string Name { get; set; }

        public string MiddleName { get; set; }

        [Required(ErrorMessage = "Поле должно быть установлено")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress (ErrorMessage = "e-mail не соответствует")]
        public string EMail { get; set; }

        [Required]
        [RegularExpression(@"^(\+\(375\)-)[0-9]{2}-[0-9]{3}-[0-9]{2}-[0-9]{2}", ErrorMessage = "Номер телефона должен соответствовать +(375)-nn-nnn-nn-nn")]
        public string PhoneNumber { get; set; }
        [Required]
        
        [RegularExpression(@"^(?!^[0-9]*$)(?!^[a-zA-Z]*$)^(.{6,})$",ErrorMessage = "Пароль должен содержать буквы и цифры и длина не меньше 6")]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "Пароли не совпадают")]
        public string RepeatPassword { get; set; }

        [Required]
        [Range(18, 99, ErrorMessage = "Недопустимый возраст")]
        public int Age { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 20, ErrorMessage = "Длина строки должна быть от 20 символов")]
        public string Address { get; set; }
    }
}