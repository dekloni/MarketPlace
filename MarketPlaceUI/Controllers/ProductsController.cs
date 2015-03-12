// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ProductsController.cs" company="FM">
//   FM
// </copyright>
// <summary>
//   The products controller.
// </summary>
// --------------------------------------------------------------------------------------------------------------------



using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Web.Http;
using System.Web.Http.Results;
using MarketPlaceUI.Models;

namespace MarketPlaceUI.Controllers
{
    /// <summary>
    /// The products controller.
    /// </summary>
    public class ProductsController : ApiController
    {
        /// <summary>
        /// The get.
        /// </summary>
        /// <returns>
        /// The <see cref="IEnumerable"/>.
        /// </returns>
        public IHttpActionResult Get()
        {
            return this.Get("latest");
            //var list = new List<ProductModel>()
            //{
            //    new ProductModel() { Id = 1, Name = "Radeon290", Description = "SuperFast" }, 
            //    new ProductModel() { Id = 1, Name = "Radeon270", Description = "Moderate Speed" }, 
            //};
            //return Ok(list);
        }

        public IHttpActionResult Get(string type)
        {
            var list = new List<ProductModel>();
            switch (type)
            {
                case "popular":
                    list.Add(new ProductModel() { Id = 1, Name = "Nvisa 980", Description = "SuperFast" });
                    list.Add(new ProductModel() { Id = 1, Name = "Nvidia 760", Description = "Moderate Speed" });
                    break;
                default:

                    list.Add(new ProductModel() { Id = 1, Name = "Radeon290", Description = "SuperFast" });
                    list.Add(new ProductModel() { Id = 1, Name = "Radeon270", Description = "Moderate Speed" });
                    break;
            }
            return Ok(list);
        }

        /// <summary>
        /// The get.
        /// </summary>
        /// <param name="id">
        /// The id.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Product
        /// <summary>
        /// The post.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Product/5
        /// <summary>
        /// The put.
        /// </summary>
        /// <param name="id">
        /// The id.
        /// </param>
        /// <param name="value">
        /// The value.
        /// </param>
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Product/5
        /// <summary>
        /// The delete.
        /// </summary>
        /// <param name="id">
        /// The id.
        /// </param>
        public void Delete(int id)
        {
        }
    }
}
