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

using System.IO;
using System.Net;
using System.Threading.Tasks;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Echo.Internal
{
    /// <summary>
    /// Custom pipeline handler that sends back the request data.
    /// </summary>
    internal class EchoCustomHttpHandler: PipelineHandler
    {
        public override void InvokeSync(IExecutionContext executionContext)
        {
            var requestContent = executionContext.RequestContext.Request.Content;
            executionContext.ResponseContext.HttpResponse = new FakeResponseData(requestContent);
        }

        public override Task<T> InvokeAsync<T>(IExecutionContext executionContext)
        {
            var requestContent = executionContext.RequestContext.Request.Content;
            executionContext.ResponseContext.HttpResponse = new FakeResponseData(requestContent);
            return Task.FromResult(default(T));
        }

    }

    internal class FakeResponseData : IWebResponseData
    {
        public FakeResponseData(byte[] requestContent)
        {
            ContentLength = requestContent.Length;
            IsSuccessStatusCode = true;
            StatusCode = HttpStatusCode.OK;
            ResponseBody = new FakeHttpResponseBody(requestContent);
        }

        public long ContentLength { get; set; }

        public string ContentType { get; set; }

        public bool IsSuccessStatusCode { get; set; }

        public IHttpResponseBody ResponseBody { get; set; }

        public HttpStatusCode StatusCode { get; set; }

        public string[] GetHeaderNames()
        {
            return new string[0];
        }

        public string GetHeaderValue(string headerName)
        {
            return null;
        }

        public bool IsHeaderPresent(string headerName)
        {
            return false;
        }
    }


    internal class FakeHttpResponseBody : IHttpResponseBody
    {
        private Stream stream;

        public FakeHttpResponseBody(byte[] requestContent)
        {
            this.stream = new MemoryStream(requestContent);
        }

        public void Dispose()
        {
            stream.Dispose();
        }

        public Stream OpenResponse()
        {
            return stream;
        }

        public Task<Stream> OpenResponseAsync()
        {
            return Task.FromResult(stream);

        }
    }
}
