using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Academy.DataLayer.Entities.User
{
    class Role
    {
        [Key]
        public int RoleId { get; set; }

        [Required (ErrorMessage ="لطفا {0}  را وارد کنید")]
        [Display(Name ="")]
        [MaxLength(200,ErrorMessage =" پارامتر {0} نمیتواند بیشتر از {1} کاراکتر باشد  ")]
        public string RoleTitle { get; set; }


    }
}
