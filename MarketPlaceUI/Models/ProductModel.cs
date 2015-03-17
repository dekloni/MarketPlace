// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ProductModel.cs" company="">
//   
// </copyright>
// <summary>
//   The product model.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MarketPlaceUI.Models
{
    /// <summary>
    /// The product model.
    /// </summary>
    public class ProductModel
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        public double Price { get; set; }
        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string Description { get; set; }

        public int CategoryId { get; set; }

        public CategoryModel CategoryModel { get; set; }

    }
}