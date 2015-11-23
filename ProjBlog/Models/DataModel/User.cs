using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ProjBlog.Models.DataModel
{
    [Table("users")]
    public class User
    {
        [Key]
        [Required]
        [ScaffoldColumn(true)]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("name")]
        [StringLength(255)]
        public string Name { get; set; }
        [Required]
        [Column("username")]
        [StringLength(150)]
        public string UserName { get; set; }
        [Required]
        [Column("email")]
        [StringLength(100)]
        public string Email { get; set; }
        [Required]
        [Column("password")]
        [StringLength(100)]
        public string PassWord { get; set; }
        [Column("usertype")]
        public byte UserType { get; set; }
        [Column("block")]
        public byte Block { get; set; }
        [Column("registerdate")]
        public DateTime RegisterDate { get; set; }
        [Column("lastvisitdate")]
        public DateTime LastVistDate { get; set; }
        [Column("active")]
        public byte Active { get; set; }
    }
}