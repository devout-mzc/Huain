using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Huain.Models
{
    public class LoginViewModel
    {
        //用户账号-可以是电话号、Email 
        [Required]
        public string UserCode { get; set; }
        //密码
        [Required]
        [DataType(DataType.Password)]
        public string PoassWord { get; set; }
        [Display(Name ="Remember me?")]
        public bool RememberMe { get; set; }
    }
}
