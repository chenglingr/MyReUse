using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace MyReUse.Models
{
    public class Account
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage = "请输入邮箱名")]
        public string Email { get; set; }
        [Required(ErrorMessage = "请输入密码")]
        public string PassWord { get; set; }
        public string  Address { get; set; }
    }
}