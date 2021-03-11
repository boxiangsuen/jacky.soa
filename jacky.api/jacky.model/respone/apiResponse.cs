using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace jacky.model.respone
{
   public class apiResponse
    {
        /// <summary>
        /// 响应状态吗
        /// </summary>
        public HttpStatusCode httpStatusCode { get; set; }

        /// <summary>
        /// 状态  成功 true  失败  false
        /// </summary>
        public Boolean Success { get; set; }

        /// <summary>
        /// 响应内容信息
        /// </summary>
        public String Message { get; set; }

        /// <summary>
        /// 返回的数据
        /// </summary>
        public Object Data { get; set; }

    }
}
