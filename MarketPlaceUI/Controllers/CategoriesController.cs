// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CategoriesController.cs" company="">
//   
// </copyright>
// <summary>
//   The categories controller.
// </summary>
// --------------------------------------------------------------------------------------------------------------------



using System.Net;
using System.Net.Http;
using System.Web.Http;
using MarketPlaceUI.Repository;

namespace MarketPlaceUI.Controllers
{
    /// <summary>
    /// The categories controller.
    /// </summary>
    public class CategoriesController : ApiController
    {
        /// <summary>
        /// The _repository.
        /// </summary>
        private MarketPlaceRepository _repository;

        /// <summary>
        /// Initializes a new instance of the <see cref="CategoriesController"/> class.
        /// </summary>
        public CategoriesController()
        {
            _repository = new MarketPlaceRepository();
        }

        // GET: api/Categories
        /// <summary>
        /// The get.
        /// </summary>
        /// <returns>
        /// The <see cref="HttpResponseMessage"/>.
        /// </returns>
        public IHttpActionResult Get()
        {
            return Ok(_repository.GetCategories());
        }

        // GET: api/Categories/5
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

        // POST: api/Categories
        /// <summary>
        /// The post.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Categories/5
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

        // DELETE: api/Categories/5
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
