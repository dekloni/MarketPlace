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
using MarketPlaceUI.Models;
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

        public IHttpActionResult Get(int id)
        {
            var record = _repository.Category(id);
            if (record == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(record);
            }
        }

        // POST: api/Categories
        /// <summary>
        /// The post.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        public IHttpActionResult Post(CategoryModel value)
        {
            var result = _repository.CreateCategory(value);
            if (result > 0)
                return Ok();
            else
            {
                return BadRequest("Category could not be created");
            }
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
        public IHttpActionResult Put(int id, CategoryModel value)
        {
            var result =_repository.UpdateCategory(value);
            if (result > 0)
                return Ok();
            else
            {
                return BadRequest();
            }

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
