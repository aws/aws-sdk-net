/*
 * Copyright 2016 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using Amazon.Util;
using Amazon.Runtime.Internal.Util;

#if AWS_ASYNC_API
using System.Threading.Tasks;
#endif



namespace Amazon.S3
{
    internal class GetHeadResponse
    {
        public HttpStatusCode? StatusCode { get; set; }
        public string HeaderValue { get; set; }
    }

    internal static class AmazonS3HttpUtil
    {
#if AWS_ASYNC_API
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
#endif

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
            var httpRequest = WebRequest.Create(url) as HttpWebRequest;
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
            var proxy = GetProxyIfAvailableAndConfigured(config);
            if (proxy != null)
            {
                httpWebRequest.Proxy = proxy;
            }
        }
        private static IWebProxy GetProxyIfAvailableAndConfigured(IClientConfig config)
        {
            return config.GetWebProxy();
        }
    }
}
