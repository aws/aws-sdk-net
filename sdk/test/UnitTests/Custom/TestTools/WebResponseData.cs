/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using Amazon.Runtime.Internal.Transform;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AWSSDK_DotNet.UnitTests.TestTools
{
    public class WebResponseData : IWebResponseData
    {
        public WebResponseData()
        {
            this.ContentType = "application/xml";
            this.StatusCode = HttpStatusCode.OK;
            this.IsSuccessStatusCode = true;
            // RFC 9110 states headers must be case insensitive
            this.Headers = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
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
            if (this.Headers.ContainsKey(headerName))
                return this.Headers[headerName];
            else
                return null;
        }
        
        public long ContentLength { get; set; }


        public IHttpResponseBody ResponseBody
        {
            get
            {
                return new HttpResponseBody();
            }
        }
    }

    public class HttpResponseBody : IHttpResponseBody
    {
        private MemoryStream emptyMemoryStream;

        public HttpResponseBody()
        {
            emptyMemoryStream = new MemoryStream();
        }
        public void Dispose()
        {
            emptyMemoryStream.Dispose();
        }

        public Stream OpenResponse()
        {
            return emptyMemoryStream;
        }

        public Task<Stream> OpenResponseAsync()
        {
            throw new NotImplementedException();
        }
    }
}
