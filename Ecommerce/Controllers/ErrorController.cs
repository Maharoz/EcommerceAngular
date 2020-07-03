using Ecommerce.Errors;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Controllers
{
    [Route("error/{code}")]
    public class ErrorController:BaseApiController
    {
        public IActionResult Error(int code)
        {
            return new ObjectResult(new ApiResponse(code));
        }
    }
}
