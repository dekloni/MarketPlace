// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Category.cs" company="ER">
//   ER
// </copyright>
// <summary>
//   The category.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MarketPlaceUI.Models
{
    /// <summary>
    /// The category.
    /// </summary>
    //[Table("Category")]
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}