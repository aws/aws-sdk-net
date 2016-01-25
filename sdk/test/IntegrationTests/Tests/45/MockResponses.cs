using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using AWSSDK_DotNet.IntegrationTests.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;

namespace AWSSDK_DotNet.IntegrationTests
{
    // Reflection to construct HttpWebResponse only works with 4.5 and higher
    public class Mocker
    {
        #region Public classes and delegates

        public class HttpResponse
        {
            public HttpResponse()
            {
                this.Headers = new Dictionary<string, string>();
            }
            public string StatusLine { get; set; }
            public IDictionary<string, string> Headers { get; private set; }
            public string Body { get; set; }
        }
        public class HttpRequestInfo
        {
            public Uri Uri { get; set; }
            public bool IsRetry { get; set; }
            public bool IsRewindable { get; set; }
            public IRequestContext RequestContext { get; set; }
        }
        public delegate HttpResponse CreateResponse(HttpRequestInfo requestInfo);

        #endregion

        #region Public properties and backing logic

        private bool HasCallback { get { return (_callback != null); } }
        private CreateResponse _callback;
        public CreateResponse CreateResponseCallback
        {
            set
            {
                if (!string.IsNullOrEmpty(RawResponse))
                    throw new InvalidOperationException("Cannot set both RawResponse and callback");
                _callback = value;
            }
            get
            {
                return _callback;
            }
        }

        private bool HasRawResponse { get { return (!string.IsNullOrEmpty(RawResponse)); } }
        private string _rawResponse;
        public string RawResponse
        {
            get { return _rawResponse; }
            set
            {
                if (_callback != null)
                    throw new InvalidOperationException("Cannot set both RawResponse and callback");
                _rawResponse = value;
            }
        }

        #endregion

        #region Public methods

        public void AddToClient(AmazonServiceClient client)
        {
            MockHttpRequestFactory.AddToClient(client, this);
        }
        public static HttpResponse CreateHttpResponse(string rawResponse)
        {
            return MockWebResponse.ParseRawReponse(rawResponse);
        }

        #endregion

        #region Internal and private methods

        internal IWebResponseData CreateMockResponse(HttpRequestInfo requestInfo)
        {
            HttpWebResponse mockResponse = CreateHttpWebResponse(requestInfo);
            var responseData = new HttpWebRequestResponseData(mockResponse);

            var isError = (int)mockResponse.StatusCode >= 300;
            if (isError)
                throw new HttpErrorResponseException(responseData);

            return responseData;
        }

        private HttpWebResponse CreateHttpWebResponse(HttpRequestInfo requestInfo)
        {
            HttpWebResponse mockResponse;
            if (HasCallback)
            {
                var httpResponse = _callback(requestInfo);
                mockResponse = MockWebResponse.CreateFromHttpResponse(httpResponse);
            }
            else if (HasRawResponse)
            {
                mockResponse = MockWebResponse.CreateFromRawResponse(RawResponse);
            }
            else
            {
                throw new InvalidOperationException("Neither RawResponse nor CreateResponseCallback configured on the mocker");
            }
            return mockResponse;
        }

        private static void LogHandlers(RuntimePipeline pipeline)
        {
            var handlers = pipeline.EnumerateHandlers().ToList();
            Console.WriteLine("Handlers for pipeline, count = {0}", handlers.Count);
            for(int i=0;i<handlers.Count;i++)
            {
                var handler = handlers[i];
                Console.WriteLine("Handler {0}: {1}", i, handler.GetType().FullName);
            }
        }

        #endregion

        #region Helper classes

        private class MockHttpRequestFactory : IHttpRequestFactory<Stream>
        {
            public IHttpRequest<Stream> CreateHttpRequest(Uri requestUri)
            {
                var request = new MockHttpRequest(requestUri, _mocker);
                return request;
            }
            public void Dispose()
            {
            }

            private Mocker _mocker;
            public MockHttpRequestFactory(Mocker mocker)
            {
                _mocker = mocker;
            }

            public static void AddToClient(AmazonServiceClient client, Mocker mocker)
            {
                var pipeline = client
                    .GetType()
                    .GetProperty("RuntimePipeline", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)
                    .GetValue(client, null)
                    as RuntimePipeline;

                var requestFactory = new MockHttpRequestFactory(mocker);
                var httpHandler = new HttpHandler<Stream>(requestFactory, client);

                Console.WriteLine("Pipeline before adding mock");
                LogHandlers(pipeline);
                pipeline.ReplaceHandler<HttpHandler<Stream>>(httpHandler);
                Console.WriteLine("Pipeline after adding mock");
                LogHandlers(pipeline);
            }
        }
        private class MockHttpRequest : IHttpRequest<Stream>
        {
            public Uri RequestUri { get; private set; }

            public MockHttpRequest(Uri requestUri, Mocker mocker)
            {
                RequestUri = requestUri;
                IsRetry = false;
                _mocker = mocker;
            }

            public bool IsRetry { get; private set; }
            public bool IsRewindable { get; private set; }
            public IRequestContext RequestContext { get; private set; }
            private Mocker _mocker;

            private HttpRequestInfo CurrentRequestInfo
            {
                get
                {
                    return new HttpRequestInfo
                    {
                        Uri = RequestUri,
                        IsRetry = IsRetry,
                        IsRewindable = IsRewindable,
                        RequestContext = RequestContext
                    };
                }
            }
            private IWebResponseData CreateResponse()
            {
                return _mocker.CreateMockResponse(CurrentRequestInfo);
            }

            public Amazon.Runtime.Internal.Transform.IWebResponseData GetResponse()
            {
                return CreateResponse();
            }

#if BCL45
            public System.Threading.Tasks.Task<IWebResponseData> GetResponseAsync(System.Threading.CancellationToken cancellationToken)
            {
                return new System.Threading.Tasks.Task<IWebResponseData>(CreateResponse);
            }

#elif BCL && !BCL45
            public IWebResponseData EndGetResponse(IAsyncResult asyncResult)
            {
                return CreateResponse();
            }
#endif

            public void ConfigureRequest(IRequestContext requestContext)
            {
                //base.ConfigureRequest(requestContext);

                IsRetry = requestContext.Retries > 0;
                IsRewindable = requestContext.Request.IsRequestStreamRewindable();
                RequestContext = requestContext;
            }

            public string Method { get; set; }
            public void SetRequestHeaders(IDictionary<string, string> headers)
            {
            }
            public Stream GetRequestContent()
            {
                return new MemoryStream();
            }

            public void WriteToRequestBody(Stream requestContent, Stream contentStream, IDictionary<string, string> contentHeaders, IRequestContext requestContext)
            {
                bool gotException = false;
                try
                {
                    var buffer = new byte[requestContext.ClientConfig.BufferSize];
                    int bytesRead = 0;
                    int bytesToRead = buffer.Length;

                    while ((bytesRead = contentStream.Read(buffer, 0, bytesToRead)) > 0)
                    {
#if AWS_ASYNC_API
                    requestContext.CancellationToken.ThrowIfCancellationRequested();
#endif
                        requestContent.Write(buffer, 0, bytesRead);
                    }
                }
                catch (Exception)
                {
                    gotException = true;

                    // If an exception occured while reading the input stream,
                    // Abort the request to signal failure to the server and prevent
                    // potentially writing an incomplete stream to the server.
                    this.Abort();
                    throw;
                }
                finally
                {
                    // Only bubble up exception from the close method if we haven't already got an exception
                    // reading and writing from the streams.
                    try
                    {
                        requestContent.Close();
                    }
                    catch (Exception)
                    {
                        if (!gotException)
                            throw;
                    }
                }
            }

            public void WriteToRequestBody(Stream requestContent, byte[] content, IDictionary<string, string> contentHeaders)
            {
                using (requestContent)
                {
                    requestContent.Write(content, 0, content.Length);
                }
            }

            public void Abort()
            {
            }

            public System.Threading.Tasks.Task<Stream> GetRequestContentAsync()
            {
                return new System.Threading.Tasks.Task<Stream>(GetRequestContent);
            }

            public void Dispose()
            {
            }

            public Stream SetupProgressListeners(Stream originalStream, long progressUpdateInterval, object sender, EventHandler<StreamTransferProgressArgs> callback)
            {
                return originalStream;
            }
        }
        private class MockWebResponse
        {
            public static HttpWebResponse CreateFromRawResponse(string rawResponse)
            {
                var httpResponse = ParseRawReponse(rawResponse);
                return CreateFromHttpResponse(httpResponse);
            }
            public static HttpWebResponse CreateFromHttpResponse(HttpResponse httpResponse)
            {
                var statusCode = ParseStatusCode(httpResponse.StatusLine);
                return Create(statusCode, httpResponse.Headers, httpResponse.Body);
            }

            public static HttpWebResponse Create(HttpStatusCode statusCode,
                IDictionary<string, string> headers, string body = null)
            {
                var type = typeof(HttpWebResponse);
                var assembly = Assembly.GetAssembly(type);
                var obj = Activator.CreateInstance(type);

                var webHeaders = new WebHeaderCollection();
                if (headers != null)
                {
                    foreach (var header in headers)
                    {
                        webHeaders.Add(header.Key, header.Value);
                    }
                }

                Stream responseBodyStream = null;
                body = body ?? string.Empty;
                responseBodyStream = UtilityMethods.CreateStreamFromString(body);

                var statusFieldInfo = type.GetField("m_StatusCode",
                    BindingFlags.NonPublic | BindingFlags.Instance);
                var headersFieldInfo = type.GetField("m_HttpResponseHeaders",
                    BindingFlags.NonPublic | BindingFlags.Instance);
                var streamFieldInfo = type.GetField("m_ConnectStream",
                    BindingFlags.NonPublic | BindingFlags.Instance);
                var contentLengthFieldInfo = type.GetField("m_ContentLength",
                    BindingFlags.NonPublic | BindingFlags.Instance);

                statusFieldInfo.SetValue(obj, statusCode);
                headersFieldInfo.SetValue(obj, webHeaders);
                streamFieldInfo.SetValue(obj, responseBodyStream);
                contentLengthFieldInfo.SetValue(obj, responseBodyStream.Length);

                return obj as HttpWebResponse;
            }

            public static HttpResponse ParseRawReponse(string rawResponse)
            {
                var response = new HttpResponse();
                var responseLines = rawResponse.Split('\r');

                if (responseLines.Count() == 0)
                    throw new ArgumentException("The resource does not contain a valid HTTP response.",
                        "resourceName");

                response.StatusLine = responseLines[0];
                var currentLine = responseLines[0];
                var statusCode = ParseStatusCode(currentLine);

                var lineIndex = 0;
                if (responseLines.Count() > 1)
                {
                    for (lineIndex = 1; lineIndex < responseLines.Count(); lineIndex++)
                    {
                        currentLine = responseLines[lineIndex];
                        if (currentLine.Trim() == string.Empty)
                        {
                            currentLine = responseLines[lineIndex - 1];
                            break;
                        }

                        var headerContent = currentLine.Split(':');
                        if (headerContent.Count() > 0)
                        {
                            response.Headers.Add(headerContent[0].Trim(), headerContent[1].Trim());
                        }
                    }
                }

                var startOfBody = rawResponse.IndexOf(currentLine) + currentLine.Length;
                response.Body = rawResponse.Substring(startOfBody).Trim();
                return response;
            }

            private static HttpStatusCode ParseStatusCode(string statusLine)
            {
                var statusCode = string.Empty;
                try
                {
                    statusCode = statusLine.Split(' ')[1];
                    return (HttpStatusCode)Enum.Parse(typeof(HttpStatusCode), statusCode);
                }
                catch (Exception exception)
                {
                    throw new ArgumentException("Invalid HTTP status line.", exception);
                }
            }
        }

        #endregion
    }
}
