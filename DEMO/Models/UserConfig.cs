using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class UserConfig
    {
        [Key]
        public int ConfigID { get; set; }

        [Required(ErrorMessage ="必填")]
        [Display(Name ="启用注册")]
        public bool Enabled { get; set; }

        [Display(Name ="禁止使用的用户名")]
        public string ProhibitUserName { get; set; } 

        [Display(Name ="启用管理员验证")]  
        [Required(ErrorMessage ="必填")]
        public bool EnableAdminiVerify { get; set; }

        [Display(Name ="启用邮箱验证")]
        [Required(ErrorMessage ="必填")]
        public bool EnableEmailVerify { get; set; }

        [Display(Name ="默认用户组")]
        [Required(ErrorMessage ="必填")]
        public int DefaultGroupId { get; set; }
    }
}
