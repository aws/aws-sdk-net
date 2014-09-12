using Amazon.Runtime.Internal.Transform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AWSSDK_DotNet35.UnitTests.TestTools
{
    public class WebResponseData : IWebResponseData
    {
        public WebResponseData()
        {
            this.ContentType = "application/xml";
            this.StatusCode = HttpStatusCode.OK;
            this.IsSuccessStatusCode = true;
            this.Headers = new Dictionary<string, string>();
        }

        public Dictionary<string,string> Headers { get; set; }

        public string ContentType { get; set; }

        public HttpStatusCode StatusCode { get; set; }

        public bool IsSuccessStatusCode { get; set; }

        public string[] GetHeaderNames()
        {
            return Headers.Keys.ToArray();
        }

        public bool IsHeaderPresent(string headerName)
        {
            return this.Headers.ContainsKey(headerName);
        }

        public string GetHeaderValue(string headerName)
        {
            return this.Headers[headerName];
        }
        
        public long ContentLength { get; set; }


        public IHttpResponseBody ResponseBody
        {
            get { throw new NotImplementedException(); }
        }
    }
}
