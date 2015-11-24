using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using log4net;
using ProjBlog.Models.ViewModel;
using ProjBlog.Models.DataModel;
using System.Data.Entity;
namespace ProjBlog.DataEntity
{
    
    public class CategoryEntity
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(CategoryEntity));
        private DbEntity db;
        public CategoryEntity(DbEntity dbEntity)
        {
            this.db = dbEntity;
        }
        public void InsertCategory(CategoryViewModel categoryViewModel)
        {
            List<Category> lCategory = categoryViewModel.ListCategory;
            foreach(Category c in lCategory)
            {
                db.Category.Add(c);
            }
            try
            {
                db.SaveChanges();
            }
            catch(Exception e)
            {
                log.Error("Error Insert Category : " + e.Message, e);
            }
        }
        public CategoryViewModel GetCategoryById(int? id)
        {
            CategoryViewModel categoryViewModel = null;
            try
            {
                List<Category> lCategory = db.Category.Where(c => c.Id == id).ToList();
                if (lCategory == null || lCategory.Count == 0)
                {
                    return null;
                }
                categoryViewModel.ListCategory = lCategory;
            }
            catch(Exception e)
            {
                log.Error("Error Get Category By Id = " + id, e);
            }
            return categoryViewModel;
        }
        public void UpdateCategory(CategoryViewModel categoryViewModel)
        {
            foreach(Category c in categoryViewModel.ListCategory)
            {
                db.Entry(c).State = EntityState.Modified;
            }
            try
            {
                db.SaveChanges();
            }
            catch(Exception e)
            {
                log.Error("Error Update Category : " + e.Message, e);
            }
        }
    }
}