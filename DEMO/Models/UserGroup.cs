using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class UserGroup
    {
        [Key]
        public int GroupID { get; set; }

        [Required(ErrorMessage ="必填")]
        [Display(Name ="名称")]
        [StringLength(20,MinimumLength =2,ErrorMessage ="{1}到{0}个字")]
        public string Name { get; set; }

        [Required(ErrorMessage ="必填")]
        [Display(Name="用户组类型")]
        public int GroupType { get; set; }

        [Required(ErrorMessage ="必填")]
        [StringLength(50,ErrorMessage ="少于{0}个字")]
        [Display(Name="说明")]
        public string Description { get; set; }
    }
}