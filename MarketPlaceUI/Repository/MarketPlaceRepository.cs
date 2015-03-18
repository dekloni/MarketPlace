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

        public IQueryable<Category> GetCategories()
        {
            var query = _context.Categories.Include("Products");
            return query.AsQueryable();
        }
        public Category Category(int id)
        {
            var query = _context.Categories.Include("Products");
            return query.SingleOrDefault(p => p.Id == id);
        }

        public int UpdateCategory(Category category)
        {

            _context.Categories.Attach(category);
            _context.Entry<Category>(category).State = EntityState.Modified;
            return _context.SaveChanges();

        }

        public int CreateCategory(Category value)
        {
            _context.Categories.Add(value);
            return _context.SaveChanges();
        }
    }
}