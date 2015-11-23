using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjBlog.DataEntity;
using log4net;
using ProjBlog.Models.ViewModel;
using ProjBlog.Models.DataModel;
namespace ProjBlog.DataEntity
{
    public class UserEntity
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(UserEntity));
        private DbEntity db;
        public UserEntity(DbEntity dbEntity)
        {
            this.db = dbEntity;
        }
        public void InsertNewUser(UserViewModel userViewModel)
        {
            User u = new User();
            u.Name = userViewModel.Name;
            u.UserName = userViewModel.UserName;
            db.User.Add(u);
            try
            {
                db.SaveChanges();
            }
            catch(Exception e)
            {
                log.Error("Error Insert New User", e);
            }
        }
        public UserViewModel GetUserById(int? id)
        {
            UserViewModel uvm = null;
            var query = db.User.Where(u => id == null ? u.Id == null : u.Id == id).ToList();
            foreach(var u in query)
            {
                uvm = new UserViewModel();
                uvm.Name = u.Name;
                uvm.UserName = u.UserName;
            }
            return uvm;
        }
    }
}