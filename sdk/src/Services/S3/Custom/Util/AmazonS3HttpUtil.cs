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
using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Util.Internal;

using System.Threading.Tasks;



namespace Amazon.S3
{
    internal class GetHeadResponse
    {
        public HttpStatusCode? StatusCode { get; set; }
        public string HeaderValue { get; set; }
    }

    internal static class AmazonS3HttpUtil
    {
        internal static async Task<GetHeadResponse> GetHeadAsync(IAmazonS3 s3Client, IClientConfig config, string url, string header)
        {
            HttpWebRequest httpRequest = GetHeadHttpRequest(config, url);
            try
            {
                using (var httpResponse = await httpRequest.GetResponseAsync().ConfigureAwait(false) as HttpWebResponse)
                {
                    return HandleWebResponse(header, httpResponse);
                }
            }
            catch (WebException we)
            {
                return HandleWebException(header, we);
            }
        }

        internal static GetHeadResponse GetHead(IAmazonS3 s3Client, IClientConfig config, string url, string header)
        {
#if NETSTANDARD
            return GetHeadAsync(s3Client, config, url, header).GetAwaiter().GetResult();
#else
            HttpWebRequest httpRequest = GetHeadHttpRequest(config, url);
            try
            {
                using (var httpResponse = httpRequest.GetResponse() as HttpWebResponse)
                {
                    return HandleWebResponse(header, httpResponse);
                }
            }
            catch (WebException we)
            {
                return HandleWebException(header, we);
            }
#endif
        }

        internal static HttpWebRequest GetHeadHttpRequest(IClientConfig config, string url)
        {
#pragma warning disable SYSLIB0014 // We need to use WebRequest.Create because the SDK still targets .NET Framework 3.5
            var httpRequest = WebRequest.Create(url) as HttpWebRequest;
#pragma warning restore SYSLIB0014
            httpRequest.Method = "HEAD";
            SetProxyIfAvailableAndConfigured(config, httpRequest);
            return httpRequest;
        }

        private static GetHeadResponse HandleWebResponse(string header, HttpWebResponse httpResponse)
        {
            return new GetHeadResponse
            {
                HeaderValue = httpResponse.Headers[header],
                StatusCode = httpResponse.StatusCode
            };
        }

        private static GetHeadResponse HandleWebException(string header, WebException we)
        {
            using (var errorResponse = we.Response as HttpWebResponse)
            {
                // The Error Response is null which is indicative of either
                // a bad request or some other problem
                if (errorResponse == null)
                {
                    return new GetHeadResponse();
                }
                else
                {
                    return new GetHeadResponse
                    {
                        HeaderValue = errorResponse.Headers[header],
                        StatusCode = errorResponse.StatusCode
                    };
                }
            }
        }

        private static void SetProxyIfAvailableAndConfigured(IClientConfig config, HttpWebRequest httpWebRequest)
        {
            var proxy = config.GetWebProxy();
            if (proxy != null)
            {
                httpWebRequest.Proxy = proxy;
            }
            else if (!NoProxyFilter.Instance.Match(httpWebRequest.RequestUri))
            {
                if (httpWebRequest.RequestUri.Scheme == Uri.UriSchemeHttp)
                {
                    httpWebRequest.Proxy = config.GetHttpProxy();
                }
                else if (httpWebRequest.RequestUri.Scheme == Uri.UriSchemeHttps)
                {
                    httpWebRequest.Proxy = config.GetHttpsProxy();
                }
            }
        }
    }
}
