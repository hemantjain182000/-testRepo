using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DataModel
{

    public class UserDetailTest
    {
        public string UserName { get; set; }
    }

    public class UserDetail
    {

        //public UserDetail()
        //{
        //    RoleList = new List<SelectListItem>();
        //}

        [Key]
        public int UserID { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name = "Login ID")]
        public string LoginName { get; set; }

        [Required(ErrorMessage = "*")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        public Role UserRole { get; set; }
        //public IEnumerable<SelectListItem> RoleList { get; set; }
    }

    public enum Role
    {
        Admin = 1,
        User = 2
    }
}
