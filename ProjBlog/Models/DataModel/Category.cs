using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ProjBlog.Models.DataModel
{
    [Table("categories")]
    public class Category
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        [StringLength(250)]
        public string Name { get; set; }
    }
}