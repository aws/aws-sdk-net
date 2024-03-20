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

namespace AWSSDK.ProtocolTests.Utils
{
    public class ProtocolTestUtils
    {
        public static Dictionary<HttpStatusCode, int> StatusCodeDictionary = new Dictionary<HttpStatusCode, int>()
        {
            {HttpStatusCode.OK, 200 }
        };
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

            var requestContext = new RequestContext(config.LogMetrics, new Amazon.Runtime.Internal.Auth.AWS4Signer())
            {
                ClientConfig = config,
                Marshaller = marshaller,
                OriginalRequest = request,
                Unmarshaller = null,
                IsAsync = false,
                ImmutableCredentials = new ImmutableCredentials("access key", "secret", "token")
            };
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

        public class NoopPipelineHandler : IPipelineHandler
        {
            public ILogger Logger { get; set; }
            public IPipelineHandler InnerHandler { get; set; }
            public IPipelineHandler OuterHandler { get; set; }

            public void AsyncCallback(IAsyncExecutionContext executionContext)
            {
            }

            public IAsyncResult InvokeAsync(IAsyncExecutionContext executionContext)
            {
                return null;
            }


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
