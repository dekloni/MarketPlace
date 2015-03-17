// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CategoryModel.cs" company="ER">
//   ER
// </copyright>
// <summary>
//   The category.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections;
using System.Collections.Generic;

namespace MarketPlaceUI.Models
{
    /// <summary>
    /// The category.
    /// </summary>
    public class CategoryModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public IEnumerable<ProductModel> Products { get; set; }
    }
}