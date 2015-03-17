using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MarketPlaceUI.Models;

namespace MarketPlaceUI.Repository
{
    public class MarketPlaceRepository
    {
        private MarketPlaceContext _context;

        public MarketPlaceRepository()
        {
            _context = new MarketPlaceContext();
        }

        public IQueryable<CategoryModel> GetCategories()
        {
            return _context.Categories;
        }
    }
}