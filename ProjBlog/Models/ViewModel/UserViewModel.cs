using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace ProjBlog.Models.ViewModel
{
    public class UserViewModel
    {
        [Required(ErrorMessage = "Name Not Null")]
        public string Name { get; set; }
        [Required(ErrorMessage = "UserName Not Null")]
        public string UserName { get; set; }
    }
}