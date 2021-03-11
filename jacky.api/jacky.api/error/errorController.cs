using jacky.model.respone;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace jacky.api.error
{
    [Route("jacky/api")]
    [ApiController]
    public class errorController : Controller
    {
        /// <summary>
        /// 错误路由
        /// </summary>
        /// <returns></returns>
        [HttpPost("error")]
        public IActionResult Index()
        {
            return Json(new apiResponse { httpStatusCode = HttpStatusCode.BadRequest, Success = false ,Message="接口服务异常！"});
        }
    }
}
