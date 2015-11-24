using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjBlog.DataEntity;
using log4net;
using ProjBlog.Models.ViewModel;
using ProjBlog.Models.DataModel;
using System.Data.Entity;
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
            List<User> lUser = userViewModel.ListUser;
            foreach (User u in lUser)
            {
                db.User.Add(u);
            }
            try
            {
                db.SaveChanges();
            }
            catch (Exception e)
            {
                log.Error("Error Insert New User :" + e.Message, e);
            }
        }
        public UserViewModel GetUserById(int? id)
        {
            UserViewModel uvm = new UserViewModel();
            var query = db.User.Where(u => u.Id == id).ToList();
            foreach(var u in query)
            {
                User user = new User();
                user.Name = u.Name;
                user.UserName = u.UserName;
                uvm.ListUser.Add(user);
            }
            return uvm;
        }
        public void UpdateUser(UserViewModel userViewModel)
        {
            List<User> lUser = userViewModel.ListUser;
            foreach(User u in lUser)
            {
                db.Entry(u).State = EntityState.Modified;
            }
            try
            {
                db.SaveChanges();
            }
            catch(Exception e)
            {
                log.Error("Error Update User : " + e.Message, e);
            }
        }
    }
}