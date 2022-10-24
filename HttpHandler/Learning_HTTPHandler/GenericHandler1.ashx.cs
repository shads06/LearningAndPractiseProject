using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Learning_HTTPHandler
{
    /// <summary>
    /// Summary description for GenericHandler1
    /// </summary>
    public class GenericHandler1 : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Write("Hello World");
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}