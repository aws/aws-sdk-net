using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AWSSDK_DotNet35.UnitTests;
using System.Net;
using System.Reflection;
using System.IO;

namespace AWSSDK.UnitTests
{
    public class MockWebResponse
    {
        public static HttpWebResponse CreateFromResource(string resourceName)
        {
            var rawResponse = Utils.GetResourceText(resourceName);

            var response = ParseRawReponse(rawResponse);
            var statusCode = ParseStatusCode(response.StatusLine);

            return Create(statusCode, response.Headers, response.Body);
        }

        public static HttpWebResponse Create(HttpStatusCode statusCode,
            IDictionary<string,string> headers, string body = null)
        {
            var type = typeof(HttpWebResponse);
            var assembly = Assembly.GetAssembly(type);
            var obj = assembly.CreateInstance("System.Net.HttpWebResponse");

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
            responseBodyStream = Utils.CreateStreamFromString(body);

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

        static HttpResponse ParseRawReponse(string rawResponse)
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

                    var index = currentLine.IndexOf(":");
                    if (index != -1)
                    {
                        var headerKey = currentLine.Substring(0, index);
                        var headerValue = currentLine.Substring(index + 1);
                        response.Headers.Add(headerKey.Trim(), headerValue.Trim());
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
                return (HttpStatusCode) Enum.Parse(typeof(HttpStatusCode), statusCode);
            }
            catch(Exception exception)
            {
                throw new ArgumentException("Invalid HTTP status line.", exception);
            }
        }

        class HttpResponse
        {
            public HttpResponse()
            {
                this.Headers = new Dictionary<string, string>();
            }
            public string StatusLine { get; set; }
            public IDictionary<string,string> Headers { get; private set; }
            public string Body { get; set; }
        }
    }
}
