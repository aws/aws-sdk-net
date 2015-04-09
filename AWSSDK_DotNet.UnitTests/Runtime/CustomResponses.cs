using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amazon.Runtime;
using System.IO;
using AWSSDK_DotNet35.UnitTests;
using Amazon.S3.Model;
using Amazon.S3.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Util;
using System.Threading;
using System.Net;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.S3;
using Amazon;
using Amazon.DynamoDBv2;
using Amazon.Util;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Amazon.Redshift;
using ServiceClientGenerator;
using System.Reflection;
using Amazon.S3.Encryption;
using System.Security.Cryptography;

namespace AWSSDK.UnitTests
{
    public static class CustomResponses
    {
        public static void SetResponse(
            AmazonServiceClient client,
            string content, string requestId, bool isOK)
        {
            var response = Create(content, requestId, isOK);
            SetResponse(client, response);
        }

        private static Func<HttpHandlerTests.MockHttpRequest, HttpWebResponse> Create(
            string content, string requestId, bool isOK)
        {
            var status = isOK ? HttpStatusCode.OK : HttpStatusCode.NotFound;

            return (request) =>
            {
                Dictionary<string, string> headers = new Dictionary<string, string>(StringComparer.Ordinal);
                if (!string.IsNullOrEmpty(requestId))
                    headers.Add(HeaderKeys.RequestIdHeader, requestId);

                var response = MockWebResponse.Create(status, headers, content);
                if (isOK)
                    return response;

                throw new HttpErrorResponseException(new HttpWebRequestResponseData(response));
            };
        }

        public static void SetResponse(
            AmazonServiceClient client,
            Func<HttpHandlerTests.MockHttpRequest, HttpWebResponse> responseCreator)
        {
            var pipeline = client
                .GetType()
                .GetProperty("RuntimePipeline", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)
                .GetValue(client, null)
                as RuntimePipeline;

            var requestFactory = new HttpHandlerTests.MockHttpRequestFactory();
            requestFactory.ResponseCreator = responseCreator;
            var httpHandler = new HttpHandler<Stream>(requestFactory, client);
            pipeline.ReplaceHandler<HttpHandler<Stream>>(httpHandler);
        }
    }
}
