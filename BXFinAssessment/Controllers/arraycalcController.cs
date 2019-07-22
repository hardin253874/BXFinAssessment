using System.Net;
using System.Net.Http;
using System.Web.Http;
using BXFinAssessment.Services;

namespace BXFinAssessment.Controllers
{
    public class arraycalcController : ApiController
    {
        // GET api/<controller>/<action>
        [HttpGet]
        [ActionName("reverse")]
        public int[] Reverse([FromUri] int[] productIds)
        {
            if (productIds == null || productIds.Length == 0) {
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Invalid productIds array"));
            }
            
            var productService = new ProductService();

            return productService.Reverse(productIds);

        }

        public class ArrayInput
        {
            public int position { get; set; }
            public int[] productIds { get; set; }
        }

        [HttpGet]
        [ActionName("deletepart")]
        public int[] DeletePart([FromUri] ArrayInput input)
        {
            if (input.productIds == null || input.productIds.Length == 0) {
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Invalid productIds array"));
            }

            if (input.position < 0 || input.position >= input.productIds.Length)
            {
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Invalid position"));
            }

            var productService = new ProductService();

            return productService.DeletePart(input.position, input.productIds);
        }

    }
}
