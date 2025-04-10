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
using Amazon.Runtime.Internal;
using Amazon.Runtime;
using Amazon.S3.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amazon.Runtime.Internal.Util;
using AWSSDK.UnitTests;
using System.IO;
using System.Net;
using System.Data.SqlTypes;
using System.Reflection;
using Moq;

namespace AWSSDK.ProtocolTests.Utils
{
    internal class ProtocolTestUtils
    {
        // return an object since this should be able to return a request or a response
        public static IRequest RunMockRequest(AmazonWebServiceRequest request, IMarshaller<IRequest, AmazonWebServiceRequest> marshaller, IClientConfig config)
        {
            var pipeline = new RuntimePipeline(new List<IPipelineHandler>
            {
                new NoopPipelineHandler(),
                new ChecksumHandler(),
                new CompressionHandler(),
                new EndpointResolver(),
                new Marshaller(),
            });

            var awsCredentials = new Mock<AWSCredentials>();
            awsCredentials.Setup(e => e.GetCredentials()).Returns(new ImmutableCredentials("access key", "secret", "token"));

            var requestContext = new RequestContext(config.LogMetrics, new Amazon.Runtime.Internal.Auth.AWS4Signer())
            {
                ClientConfig = config,
                Marshaller = marshaller,
                OriginalRequest = request,
                Unmarshaller = null,
                IsAsync = false,
                Identity = awsCredentials.Object,
            };

            // Create and set the internal ServiceMetadata via reflection
            var serviceMetaData = Assembly.GetAssembly(requestContext.GetType()).CreateInstance("Amazon.Runtime.Internal.ServiceMetadata");
            requestContext.GetType().GetProperty("ServiceMetaData").SetValue(requestContext, serviceMetaData);

            var executionContext = new ExecutionContext(
                requestContext,
                new ResponseContext()
            );

            pipeline.InvokeSync(executionContext);


            return requestContext.Request;
        }

        public static byte[] ConvertStreamToByteArray(Stream stream)
        {
            using (var memoryStream = new MemoryStream())
            {
                stream.CopyTo(memoryStream);
                return memoryStream.ToArray();
            }
        }

        public static string GetContentStreamBody(Stream contentStream)
        {
            byte[] contentStreamBytes = ConvertStreamToByteArray(contentStream);
            var actualBody = Encoding.UTF8.GetString(contentStreamBytes);
            return actualBody;
        }

        /// <summary>
        /// This takes a uri and returns the querySegments from the original string. We don't use
        /// uri.Query because .NET automatically decodes some characters when returning the URI.
        /// </summary>
        /// <param name="uri"></param>
        /// <returns>An array of query segments</returns>
        public static string[] GetQuerySegmentsFromOriginalString(Uri uri)
        {
            var originalString = uri.OriginalString;
            var questionIndex = originalString.IndexOf('?');
            string query = originalString.Substring(questionIndex + 1);
            return query.Split('&');
        }
        /// <summary>
        /// Similar to <seealso cref="GetQuerySegmentsFromOriginalString(Uri)"/> this function takes
        /// a uri and resource path from the uri's original string. We want the encoded version.
        /// </summary>
        /// <param name="uri"></param>
        /// <returns>The resource path of the uri</returns>
        public static string GetEncodedResourcePathFromOriginalString(Uri uri)
        {
            var originalString = uri.OriginalString;
            int doubleSlashIndex = originalString.IndexOf("//");
            int firstSlashAfterDoubleSlash = originalString.IndexOf('/', doubleSlashIndex + 2);
            var questionIndex = originalString.IndexOf('?');
            if (questionIndex > 0)
            {
                return originalString.Substring(firstSlashAfterDoubleSlash, questionIndex - firstSlashAfterDoubleSlash);
            }
            else
            {
                return originalString.Substring(firstSlashAfterDoubleSlash);
            }

        }
        public class NoopPipelineHandler : IPipelineHandler
        {
            public ILogger Logger { get; set; }
            public IPipelineHandler InnerHandler { get; set; }
            public IPipelineHandler OuterHandler { get; set; }

            public virtual System.Threading.Tasks.Task<T> InvokeAsync<T>(IExecutionContext executionContext)
                where T : AmazonWebServiceResponse, new()
            {
                return null;
            }

            public void InvokeSync(IExecutionContext executionContext)
            {
            }
        }



    }
}
