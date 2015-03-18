using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MarketPlaceUI.Models;
using Microsoft.Ajax.Utilities;

namespace MarketPlaceUI.Repository
{
    public class MarketPlaceRepository
    {
        private MarketPlaceContext _context;

        public MarketPlaceRepository()
        {
            _context = new MarketPlaceContext();
            _context.Database.Log = this.log;
        }

        private void log(string obj)
        {
            Console.Write(obj);
        }

        public IQueryable<CategoryModel> GetCategories()
        {
            return _context.Categories;
        }
        public CategoryModel Category(int id)
        {
            return _context.Categories.Find(id);
        }

        public int UpdateCategory(CategoryModel category)
        {

            _context.Categories.Attach(category);
            _context.Entry<CategoryModel>(category).State = EntityState.Modified;
            return _context.SaveChanges();

        }

        public int CreateCategory(CategoryModel value)
        {
            _context.Categories.Add(value);
            return _context.SaveChanges();
        }
    }
}