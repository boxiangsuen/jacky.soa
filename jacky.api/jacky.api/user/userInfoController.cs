using jacky.model.respone;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace jacky.api.user
{
    [Route("jacky/api")]
    [ApiController]
    public class userInfoController : Controller
    {
        [HttpPost("get-User")]
        public IActionResult GetUser()
        {
            return Json(new apiResponse { httpStatusCode = HttpStatusCode.OK, Success = true, Message = "get-User接口" });
        }
    }
}
