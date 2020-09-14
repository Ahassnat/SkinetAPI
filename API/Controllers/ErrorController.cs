using API.Errors;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{

    [Route("errors/{code}")]
    [ApiExplorerSettings(IgnoreApi = true)] // to ignore the http return type API
    public class ErrorController : BaseApiController
    {

        public IActionResult Error(int code)
        {
            return new ObjectResult(new ApiResponse(code));
        }
    }

}